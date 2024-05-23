using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Item added successfully.");
        }

        public void DisplayAllItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
                return;
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public Item FindItemById(int id)
        {
            return items.FirstOrDefault(item => item.ID == id);
        }

        public void UpdateItem(int id, string newName, decimal newPrice, int newQuantity)
        {
            Item item = FindItemById(id);
            if (item != null)
            {
                item.Name = newName;
                item.Price = newPrice;
                item.Quantity = newQuantity;
                Console.WriteLine("Item updated successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void DeleteItem(int id)
        {
            Item item = FindItemById(id);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
    }
}
