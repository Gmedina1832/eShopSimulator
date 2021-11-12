/*Gabriel Medina Pereira
 *Course: COMP2400
  File: Inventory.cs
  Description: eShop Simulation Object */

using System;
using System.Collections.Generic;


namespace eShopSimulator
{
    class Inventory
    {
        public static Random random = new Random();
        private Item pant; 
        private Item shirt;
        private Item shoes;
        public Dictionary<Item, int> stock = new Dictionary<Item, int>();
        public Dictionary<Item, float> prices = new Dictionary<Item, float>();

        public Inventory()
        {
            for (int i = 0; i < 10; i++)
            {
                pant = new Item("Pants", random.Next(100, 199).GetHashCode());
                shirt = new Item("Shirt", random.Next(200, 299).GetHashCode());
                shoes = new Item("Shoes", random.Next(300, 399).GetHashCode());
            }
            
            this.prices.Add(pant,12.99F);
            this.prices.Add(shirt, 13.99F);
            this.prices.Add(shoes, 10.99F);
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
            return prices;
        }

        public void RemoveStock(Item item, int qty)
        {
            //Verificar si existe el key 
            if (stock.ContainsKey(item))
            {
                stock[item] -= qty;
            }
            else
            {
                stock.Remove(item);
            }
        }

    }
}
