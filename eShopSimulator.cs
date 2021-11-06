using System;

namespace eShopSimulator
{
    class eShopSimulator
    {
        static int opt;
        static void Main(string[] args)
        {
            eShopSimulator ess = new eShopSimulator();

            ess.Init();

            MainMenu();
            opt = GetOption("Select an Option");
            Shop();
            Cart();
            CheckOut();
            Exit();

        }

        void Init()
        {
            Console.WriteLine("Initialization?....");
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to e-Shop Simulator!");

            Console.WriteLine("[1] Enter e-Shop - Browse Items");
            Console.WriteLine("[2] Exit simulation");


        }

        static void Shop()
        {
            Console.WriteLine("Shop items");
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
            Console.WriteLine("Closing Shop");            
        }

        static int GetOption(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    
                }
            }            
        }        
    }
}
