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
        public Dictionary<Item, float> stock = new Dictionary<Item, float>();
        public static List<Item> items = new List<Item>();

        public Inventory(List<Item> items)
        {
            pant = new Item("Pants", random.Next(100,199).GetHashCode());
            shirt = new Item("Shirt", random.Next(200,299).GetHashCode());
            //items.Add(pant);            

            //foreach (Item i in items)
            //{
            //    stock.Add(i, 12.99F);
            //}
            //var stock = new Dictionary<Item, float>()
            //{
            //    {pant, 12.99F },
            //    {shirt, 10.99F }
            //};
            this.stock.Add(pant,12.99F);
            this.stock.Add(shirt, 13.99F);
        }

        public Inventory() : this(items)
        {

        }

        public Dictionary<Item, float> Stock()
        {
            return stock;
        }


    }
}
