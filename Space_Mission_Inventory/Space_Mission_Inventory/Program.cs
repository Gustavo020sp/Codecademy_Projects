namespace Space_Mission_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] spaceInventory;
            spaceInventory = new string[] { "Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools" };

            int[] itemQuantities;
            itemQuantities = new int[] { 10, 8, 15, 5, 6, 9, 4, 7 };

            if (spaceInventory.Length == 8)
            {
                Console.WriteLine("Space Inventory is ready to go!");
            }
            else if (spaceInventory.Length > 8)
            {
                Console.WriteLine("Too many items!");
            }
            else
            {
                Console.WriteLine("Add more items!");
            }

            int seconditem = Array.IndexOf(spaceInventory, "Oxygen Tanks");
            int secondquantity = Array.IndexOf(itemQuantities, 8);

            Console.WriteLine(spaceInventory[seconditem] + ", " +  itemQuantities[secondquantity]);

            spaceInventory[7] = "Scientific Instruments"; // item replacement
            itemQuantities[7] = 5;

            int itemtest = Array.IndexOf(itemQuantities, 5);
            Console.WriteLine($"The first item with quantity 5 is at position {itemtest + 1}");

            Array.Reverse(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);

            Array.Sort(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);
        }
    }
}
