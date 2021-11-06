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
                      
            do
            {
                switch (opt)
                {
                    case 1:
                        Shop();
                        break;
                }                
            } while (!Exit(opt));
            

        }

        void Init()
        {
            Console.WriteLine("Initialization?....");
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to e-Shop Simulator!\n");

            //Console.WriteLine("[0] Exit simulation");
            //Console.WriteLine("[1] Enter e-Shop - Browse Items");            

            opt = GetOption("[0] Exit simulation\n[1] Enter e-Shop - Browse Items\n\nSelect an Option: ");
        }

        static void Shop()
        {
            string[] items = { "Item 1", "Item 2", "Item 3" };
            Console.WriteLine("Shop Items\n");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            int shopOpt = GetOption("[0]-Menu [1]-Add to cart [2]-View Cart [3]-Checkout");
            
            switch(shopOpt)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    Console.WriteLine("Item Added to cart");
                    break;
                case 2:
                    Console.WriteLine("Showing items on cart");
                    break;
                case 3:
                    Console.WriteLine("Checkout items");
                    break;
            }
        }

        static void Cart()
        {
            Console.WriteLine("Cart items");
        }

        static void CheckOut()
        {
            Console.WriteLine("Checkout items");
        }

        static bool Exit(int opt)
        {
            if(opt == 0)
            {
                Console.WriteLine("Goodbye!");
                return true;
            }
            return false;            
        }

        static int GetOption(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    
                }
            }            
        }        
    }
}
