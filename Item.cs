using System;
using System.Collections.Generic;
using System.Linq;

namespace eShopSimulator
{
    class Item
    {        
        public string name;
        //public float price;
        //public int stock;
        public int itemCode;

        public Item(string iName, int iCode)
        {            
            name = iName;
            itemCode = iCode;
            //price = iPrice;
            //stock = iStock;                    
        }
        //List<Item> inventory = new List<Item>();
        //List<Item> cart = new List<Item>();
        //Item[] shirtInStock = new Item[20];
        //Random random = new Random();

        //Item shirt; 
        //for (int i = 0; i < shirtInStock.Length; i++)
        //{
        //    shirt = new Item("Shirt", random.Next(GetHashCode()));
        //    shirtInStock[i] = shirt;
        //}

        //foreach(Item i in shirtInStock)
        //{
        //    if (i.itemCode == shirtInStock[0].itemCode)
        //    {
        //        Console.WriteLine(i.itemCode);
        //    }
        //}
        //Item pants = new Item("Pants", 10.99F, 20);
        //inventory.Add(shirt);
        //inventory.Add(pants);

        //Console.WriteLine(inventory[0].name);

        public override string ToString()
        {
            return $"{name,-10}" + $"{itemCode,-10}";
            //return $"{name,-10}" + $"{price,-10}" + $"{stock,-10}";
        }

    }
}
