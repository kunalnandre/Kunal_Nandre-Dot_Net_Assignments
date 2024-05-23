using System;

namespace InventoryManagementSystem
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Item(int id, string name, decimal price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }
}
