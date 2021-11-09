using System;
using System.Collections.Generic;
using System.Linq;

namespace eShopSimulator
{
    class eShopSimulator
    {
        //public static Random random = new Random();
        //public static Item pant;
        //public static Item shirt;
        //public static List<Item> items = new List<Item>();
        static void Main()
        {
            eShopSimulator ess = new eShopSimulator();
            
            ess.Init();

            MainMenu();
            Shop();
            AddToCart();
            Cart();
            CheckOut();

        }

        void Init()
        {
            Console.WriteLine("Initialization...");
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to e-Shop Simulator!\n");             
        }

        static void Shop()
        {
            Console.WriteLine("Show items in shop inventory\n");
            Inventory inventory = new Inventory();
            var stock = inventory.Stock();
            var price = inventory.Price();

            for (int i = 0; i < stock.Count; i++)
            {
                Console.WriteLine(stock.ElementAt(i).Key.itemName + " $"+ price.ElementAt(i).Value  + " available: " + stock.ElementAt(i).Value);
            }
        }

        static void AddToCart()
        {
            Console.WriteLine("Add items to cart");
        }

        static void Cart()
        {
            Console.WriteLine("Cart items");
        }

        static void CheckOut()
        {
            Console.WriteLine("Checkout items");
        }

        static void Exit()
        {
            Console.WriteLine("Exit eShopSimulator");
            //if(opt == 0)
            //{
            //    Console.WriteLine("Goodbye!");
            //    return true;
            //}
            //return false;            
        }

        //static int GetOption(string prompt)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write(prompt);
        //            return Convert.ToInt32(Console.ReadLine());
        //        }
        //        catch
        //        {
                    
        //        }
        //    }            
        //}        
    }
}
