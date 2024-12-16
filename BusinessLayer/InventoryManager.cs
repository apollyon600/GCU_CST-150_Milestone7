using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace Milestone7.BusinessLayer
{
    internal class InventoryManager
    {
        internal enum InventoryType
        {
            CHEST,
            PLAYER,
            ARMOR
        }

        private Item[][] inventory;
        private Item[][] chest;
        private Item[] armor;

        public InventoryManager()
        {
            chest = new Item[3][];
            inventory = new Item[4][];
            armor = new Item[4];

            Load();
        }

        internal Item GetItem(InventoryType type, int y, int x)
        {
            switch (type)
            {
                case InventoryType.ARMOR:
                    if (x > 3 || x < 0)
                        throw new ArgumentException("Slot coordinates must be from 0-3.");

                    return armor[x];
                case InventoryType.PLAYER:
                    if (y > 3 || y < 0)
                        throw new ArgumentException("Row coordinates must be from 0-3");

                    if (x < 0 || x > 8) throw new ArgumentException("Slot coordinates must be from 0-8");

                    return inventory[y][x];
                case InventoryType.CHEST:
                    if (y > 2 || y < 0)
                        throw new ArgumentException("Row coordinates must be from 0-2");

                    if (x < 0 || x > 8) throw new ArgumentException("Slot coordinates must be from 0-8");

                    return chest[y][x];
            }

            return null;
        }

        internal void HandleItems(
            InventoryType inventoryType,
            Item itemOne, Item itemTwo,
            bool shouldSplit
        )
        {
            // If both slots are empty, then there's no point in touching.
            if (itemOne == null && itemTwo == null) return;

            switch (inventoryType)
            {
                case InventoryType.ARMOR:
                    return;
                case InventoryType.PLAYER:
                    // If both items exist, swap places.
                    if (itemOne.Exists() && itemTwo.Exists())
                    {
                        // If both items are the same, merge itemOne to itemTwo
                        if (itemOne.Name == itemTwo.Name)
                        {
                            int half = itemOne.Quantity / 2;
                            if (shouldSplit && half > 0)
                            {
                                itemTwo.Quantity += half;
                                itemOne.Quantity -= half;

                                itemOne.Redraw();
                                itemTwo.Redraw();
                            }
                            else
                            {
                                itemTwo.Quantity += itemOne.Quantity;
                                itemOne.Delete();

                                itemOne.Redraw();
                                itemTwo.Redraw();
                            }
                        }
                        else
                        {
                            // Swap items
                            itemOne.SwapWith(itemTwo);

                            itemOne.Redraw();
                            itemTwo.Redraw();
                        }
                    }
                    else if (itemOne.Exists() && !itemTwo.Exists())
                    {
                        int half = itemOne.Quantity / 2;
                        if (shouldSplit && half > 0)
                        {
                            itemOne.CopyTo(itemTwo);
                            itemTwo.Quantity = half;
                            itemOne.Quantity -= half;

                            itemOne.Redraw();
                            itemTwo.Redraw();
                        }
                        else
                        {
                            // Move itemOne to itemTwo's position
                            itemOne.SwapWith(itemTwo);
                            itemOne.Delete();

                            itemOne.Redraw();
                            itemTwo.Redraw();
                        }
                    }
                    else if (!itemOne.Exists() && itemTwo.Exists())
                    {
                        int half = itemTwo.Quantity / 2;
                        if (shouldSplit && half > 0)
                        {
                            itemTwo.CopyTo(itemOne);
                            itemTwo.Quantity = half;
                            itemOne.Quantity -= half;

                            itemOne.Redraw();
                            itemTwo.Redraw();
                        }
                        else
                        {
                            // Move itemOne to itemTwo's position
                            itemOne.SwapWith(itemTwo);
                            itemTwo.Delete();

                            itemOne.Redraw();
                            itemTwo.Redraw();
                        }
                    }
                    return;
            }
        }

        internal bool IsItem(string Name)
        {
            string Path = $"../../Images/Items/{Name}.png";
            return File.Exists(Path);
        }

        internal void AddItem(string Name, string Description, int Quantity)
        {
            string[] lines = File.ReadAllLines("./Data/Inventory.txt");
            // Iterate over the rows
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int index = i * 9 + j; // Calculate the flat index for the line
                    if (index >= lines.Length || string.IsNullOrWhiteSpace(lines[index]) || lines[index] == "null")
                    {
                        inventory[i][j].Name = Name;
                        inventory[i][j].Description = Description;
                        inventory[i][j].Quantity = Quantity;
                        inventory[i][j].ImagePath = $"../../Images/Items/{Name}.png";
                        return;
                    }

                    string[] parts = lines[index].Split(';');
                    if (parts.Length < 3)
                    {
                        inventory[i][j].Name = Name;
                        inventory[i][j].Description = Description;
                        inventory[i][j].Quantity = Quantity;
                        inventory[i][j].ImagePath = $"../../Images/Items/{Name}.png";
                        return;
                    }
                }
            }
        }

        internal void Save()
        {
            List<string> lines = new List<string>();

            foreach (Item[] row in inventory)
            {
                foreach (Item item in row)
                {
                    if (item == null || item.Quantity == 0)
                    {
                        lines.Add("null"); // Add an empty line for null items
                    }
                    else
                    {
                        lines.Add($"{item.Name};{item.Description};{item.Quantity}");
                    }
                }
            }

            File.WriteAllLines("./Data/Inventory.txt", lines);

            // Chest
            lines = new List<string>();

            foreach (Item[] row in chest)
            {
                foreach (Item item in row)
                {
                    if (item == null)
                    {
                        lines.Add("null"); // Add an empty line for null items
                    }
                    else
                    {
                        lines.Add($"{item.Name};{item.Description};{item.Quantity}");
                    }
                }
            }

            File.WriteAllLines("./Data/Chest.txt", lines);
        }

        internal void Load()
        {
            string[] lines = File.ReadAllLines("./Data/Inventory.txt");
            inventory = new Item[4][]; // Initialize 4 rows

            // Iterate over the rows
            for (int i = 0; i < 4; i++)
            {
                inventory[i] = new Item[9]; // Initialize each row with 9 elements

                for (int j = 0; j < 9; j++)
                {
                    int index = i * 9 + j; // Calculate the flat index for the line
                    if (index >= lines.Length || string.IsNullOrWhiteSpace(lines[index]) || lines[index] == "null")
                    {
                        inventory[i][j] = new Item
                        {
                            Name = null,
                            Description = null,
                            Quantity = 0,
                            ImagePath = null
                        }; // Assign null if line is missing or empty
                        continue;
                    }

                    string[] parts = lines[index].Split(';');
                    if (parts.Length < 3)
                    {
                        inventory[i][j] = new Item
                        {
                            Name = null,
                            Description = null,
                            Quantity = 0,
                            ImagePath = null
                        }; // Assign null if the line format is invalid
                        continue;
                    }

                    inventory[i][j] = new Item
                    {
                        Name = parts[0],
                        Description = parts[1],
                        Quantity = int.TryParse(parts[2], out int quantity) ? quantity : 0,
                        ImagePath = $"../../Images/Items/{parts[0]}.png"
                    };
                }
            }

            // Armor
            lines = File.ReadAllLines("./Data/Armor.txt");
            armor = new Item[4];

            for (int i = 0; i < 4; i++)
            {
                if (i >= lines.Length || string.IsNullOrWhiteSpace(lines[i]) || lines[i] == "null")
                {
                    armor[i] = new Item
                    {
                        Name = null,
                        Description = null,
                        Quantity = 0,
                        ImagePath = null
                    }; // Assign null if line is missing or empty
                    continue;
                }

                string[] parts = lines[i].Split(';');
                if (parts.Length < 3)
                {
                    armor[i] = new Item
                    {
                        Name = null,
                        Description = null,
                        Quantity = 0,
                        ImagePath = null
                    }; // Assign null if the line format is invalid
                    continue;
                }

                armor[i] = new Item
                {
                    Name = parts[0],
                    Description = parts[1],
                    Quantity = int.TryParse(parts[2], out int quantity) ? quantity : 0,
                    ImagePath = $"../../Images/Items/{parts[0]}.png"
                };
            }


            // Chest
            lines = File.ReadAllLines("./Data/Chest.txt");
            chest = new Item[3][]; // Initialize 3 rows

            // Iterate over the rows
            for (int i = 0; i < 3; i++)
            {
                chest[i] = new Item[9]; // Initialize each row with 9 elements

                for (int j = 0; j < 9; j++)
                {
                    int index = i * 9 + j; // Calculate the flat index for the line
                    if (index >= lines.Length || string.IsNullOrWhiteSpace(lines[index]) || lines[index] == "null")
                    {
                        chest[i][j] = new Item
                        {
                            Name = null,
                            Description = null,
                            Quantity = 0,
                            ImagePath = null
                        }; // Assign null if line is missing or empty
                        continue;
                    }

                    string[] parts = lines[index].Split(';');
                    if (parts.Length < 3)
                    {
                        chest[i][j] = new Item
                        {
                            Name = null,
                            Description = null,
                            Quantity = 0,
                            ImagePath = null
                        }; // Assign null if the line format is invalid
                        continue;
                    }

                    chest[i][j] = new Item
                    {
                        Name = parts[0],
                        Description = parts[1],
                        Quantity = int.TryParse(parts[2], out int quantity) ? quantity : 0,
                        ImagePath = $"../../Images/Items/{parts[0]}.png"
                    };
                }
            }
        }

    }
}
