using System;

namespace eShopSimulator
{
    class eShopSimulator
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to e-Shop!");

            Console.WriteLine("[1] Shop");
            Console.WriteLine("[2] Exit");

            Console.Write("Select an Option: ");
            Console.ReadLine();
        }
    }
}
