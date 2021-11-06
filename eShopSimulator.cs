using System;

namespace eShopSimulator
{
    class eShopSimulator
    {
        static void Main(string[] args)
        {
            MainMenu();
            GetOption();
            Shop();
            Cart();
            CheckOut();

        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to e-Shop Simulator!");

            Console.WriteLine("[1] Enter e-Shop");
            Console.WriteLine("[2] Exit");

            Console.WriteLine("Select an Option: ");
        }

        static void Shop()
        {
            Console.WriteLine("Shop");
        }

        static void Cart()
        {
            Console.WriteLine("Shopping Cart");
        }

        static void CheckOut()
        {
            Console.WriteLine("Checkout");
        }

        static void GetOption()
        {
            Console.WriteLine("Option Selection...");
        }

        
        
    }
}
