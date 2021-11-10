using System;
using System.Collections.Generic;
using System.Linq;

namespace eShopSimulator
{
    class eShopSimulator
    {
        static int opt;

        static Inventory inventory = new Inventory();

        static bool buyItem;


        static void Main()
        {
            eShopSimulator ess = new eShopSimulator();
            
            ess.Init();

            MainMenu();
            
            opt = GetOption("Make a Selection: [1] Enter Shop  [2] Exit Shop : ");
            switch(opt)
            {
                case 1:
                    Shop();
                    CheckOutItems(buyItem);
                    break;
                case 2:
                    Exit();
                    break;
            }
            //Shop();
            //AddToCart();
            //Cart();
            //CheckOut();

        }

        void Init()
        {            
            //var stock = inventory.Stock();
            //var price = inventory.Price();
        }

        //MAIN MENU---------------------------------->

        static void MainMenu()
        {
            Console.WriteLine("Welcome to e-Shop Simulator!\n");
        }

        //-------------------------------------------^

        //SHOP DISPLAY------------------------------->

        static void Shop()
        {
            Console.Clear();
            ShopInventory(inventory);

            opt = GetOption("\nMake a Selection: [1] Shop-Add To Cart [2] Cart [3] Exit : ");

            if (opt == 1)
            {
                AddToCart(inventory);
                
            }
        }

        //--------------------------------------------^

        static void ShopInventory(Inventory inventory)
        {
            Console.WriteLine("Items in Shop\n");
            var stock = inventory.Stock();
            var price = inventory.Price();

            for (int i = 0; i < stock.Count; i++)
            {
                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine("      ["+i+"]-"+stock.ElementAt(i).Key.itemName + " $" + price.ElementAt(i).Value + " Qty: " + stock.ElementAt(i).Value);
            }
        }

        static void AddToCart(Inventory inventory)
        {
            Console.Clear();
            do
            {
                Console.WriteLine("Add Item To Cart\n");
                ShopInventory(inventory);
                opt = GetOption("\nSelect an Item From Shop: ");
                ProcessSelect(opt, inventory);
                Console.WriteLine("|-----------------------------------|");
            } while (CheckOut(GetOption("Check Out? [1] YES")));
        }

        static void ProcessSelect(int selection, Inventory inventory)
        {
            var stock = inventory.Stock();
            var price = inventory.Price();
            Console.Clear();
            Console.WriteLine("Item Added To Cart");
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("      [" + selection + "]-" + stock.ElementAt(selection).Key.itemName + " $" + price.ElementAt(selection).Value + " Qty: " + stock.ElementAt(selection).Value);

        }

        //DISPLAY SELECTED ITEMS IN CART------------>

        static void Cart()
        {
            Console.WriteLine("Cart items");
        }

        //------------------------------------------^

        //CHECKOUT PROCESS-------------------------->

        static void CheckOutItems(bool finishTransaction)
        {
            Console.Clear();
            Console.WriteLine("End Of Transaction: " + finishTransaction);
        }

        //------------------------------------------^

        //EXIT APP FUNCTIONS------------------------>

        static bool CheckOut(int checkOut)
        {
            if (checkOut == 1)
            {
                buyItem = true;
                return false;                
            }
            else
            {
                buyItem = false;
                return true;                
            }
        }

        static void Exit()
        {
            Console.WriteLine("GOOD BYE!");         
        }

        //------------------------------------------^

        //INPUT OPTIONS----------------------------->

        static void PressEnter()
        {
            Console.Write("Continue...");
            Console.ReadLine();
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

        //-----------------------------------------^




    }
}
