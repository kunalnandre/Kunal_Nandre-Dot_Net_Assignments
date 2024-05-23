using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display All Items");
                Console.WriteLine("3. Find Item by ID");
                Console.WriteLine("4. Update Item");
                Console.WriteLine("5. Delete Item");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItem(inventory);
                        break;
                    case "2":
                        inventory.DisplayAllItems();
                        break;
                    case "3":
                        FindItem(inventory);
                        break;
                    case "4":
                        UpdateItem(inventory);
                        break;
                    case "5":
                        DeleteItem(inventory);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void AddItem(Inventory inventory)
        {
            Console.Write("Enter Item ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Item Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Item Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Item newItem = new Item(id, name, price, quantity);
            inventory.AddItem(newItem);
        }

        static void FindItem(Inventory inventory)
        {
            Console.Write("Enter Item ID to find: ");
            int id = int.Parse(Console.ReadLine());
            Item item = inventory.FindItemById(id);
            if (item != null)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        static void UpdateItem(Inventory inventory)
        {
            Console.Write("Enter Item ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new Item Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter new Item Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter new Item Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            inventory.UpdateItem(id, name, price, quantity);
        }

        static void DeleteItem(Inventory inventory)
        {
            Console.Write("Enter Item ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            inventory.DeleteItem(id);
        }
    }
}
