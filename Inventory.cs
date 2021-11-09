using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSimulator
{
    class Inventory
    {
        public static Random random = new Random();
        public Item pant; 
        public Item shirt;
        public Item shoes;
        public Dictionary<Item, int> stock = new Dictionary<Item, int>();
        public Dictionary<Item, float> items = new Dictionary<Item, float>();

        public Inventory()
        {
            for (int i = 0; i < 10; i++)
            {
                pant = new Item("Pants", random.Next(100, 199).GetHashCode());
                shirt = new Item("Shirt", random.Next(200, 299).GetHashCode());
                shoes = new Item("Shoes", random.Next(300, 399).GetHashCode());
            }
            
            this.items.Add(pant,12.99F);
            this.items.Add(shirt, 13.99F);
            this.items.Add(shoes, 10.99F);
            this.stock.Add(pant, 10);
            this.stock.Add(shirt, 10);
            this.stock.Add(shoes, 10);
        }

        public Dictionary<Item, int> Stock()
        {
            return stock;
        }

        public Dictionary<Item, float> Price()
        {
            return items;
        }


    }
}
