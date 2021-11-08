using System;
using System.Collections.Generic;
using System.Linq;

namespace eShopSimulator
{
    class eShopSimulator
    {
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
            Console.WriteLine("Initialization");            
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to e-Shop Simulator!\n");             
        }

        static void Shop()
        {
            Console.WriteLine("Show items in shop inventory");
        }

        //static void Inventory()
        //{

        //}

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
