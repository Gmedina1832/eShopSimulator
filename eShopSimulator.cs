/*Gabriel Medina Pereira
 *Course: COMP2400
  File: eShopSimulator.cs
  Description: eShop Simulation Console App */
using System;
using System.Collections.Generic;
using System.Linq;

namespace eShopSimulator
{
    class eShopSimulator
    {
        static int opt;

        static Inventory inventory = new Inventory();

        public static Cart defaultCart = new Cart();
        

        static bool buyItem;


        static void Main()
        {
            do
            {
                Console.Clear();
                MainMenu();

                opt = GetOption("Make a Selection: [1] Enter Shop  [2] Exit Shop : ");
                switch (opt)
                {
                    case 1:
                        Shop();
                        if (defaultCart.CartItems().Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Items on Cart " + defaultCart.CartItems().Count + "\n");
                            buyItem = CheckOut(GetOption("Check Out? [1] YES [2] NO"));
                        }
                        if (buyItem)
                        {
                            CheckOutItems(buyItem);
                            opt = 2;
                            PressEnter();
                        }
                        break;
                    case 2:
                        if (defaultCart.CartItems().Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Items on Cart " + defaultCart.CartItems().Count + "\n");
                            buyItem = CheckOut(GetOption("Check Out? [1] YES [2] NO"));
                            if (buyItem)
                            {
                                CheckOutItems(buyItem);
                                opt = 2;
                                PressEnter();
                            }
                        }
                        Exit();
                        break;
                }
            } while (opt != 2);
            
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
            //Dictionary<Item, int> cart;            
            do
            {
                Console.Clear();
                ShopInventory(inventory);
                opt = GetOption("\nMake a Selection: [1] Shop-Add To Cart [2] Cart [3] Main Menu : ");

                if (opt == 1)
                {
                    do
                    {
                        AddToCart(inventory);
                        if (opt != -1)
                        {
                            buyItem = CheckOut(GetOption("Check Out? [1] YES [2] NO"));
                        }
                        if (opt == -1)
                        {
                            buyItem = true;
                        }
                    } while (!buyItem);
                    Console.WriteLine("|-----------------------------------|");
                    
                }
                if (opt == 2)
                {
                    if (defaultCart.CartItems() != null)
                    {
                        Cart(defaultCart.CartItems(), inventory.Price());
                        PressEnter();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nNo items In Cart\n");
                        PressEnter();
                    }
                }
            } while (opt != 3);
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
            Console.WriteLine("|-----------------------------------|");
            if (defaultCart.CartItems().Count > 0)
            {
                Console.WriteLine("\nCart");
                for (int i = 0; i < defaultCart.CartItems().Count; i++)
                {
                    Console.WriteLine("[" + i + "]-" + defaultCart.CartItems().ElementAt(i).Key.itemName + " Qty: " + defaultCart.CartItems().ElementAt(i).Value);
                }
            }
        }

        static void AddToCart(Inventory inventory)
        {
            Dictionary<Item, int> cart;
            
            Console.Clear();
            Console.WriteLine("Add Item To Cart\n");
            ShopInventory(inventory);
            opt = GetOption("\n[-1] Back | Select an Item From Shop: ");            

            if (opt >= 0)
            {
                cart = new Dictionary<Item, int>(ProcessSelect(opt, inventory));
            }
                                  

        }

        static Dictionary<Item, int> ProcessSelect(int selection, Inventory inventory)
        {
            var stock = inventory.Stock();
            var price = inventory.Price();
            Console.Clear();
            Console.WriteLine("Item Added To Cart");
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("      [" + selection + "]-" + stock.ElementAt(selection).Key.itemName + " $" + price.ElementAt(selection).Value + " Qty: " + stock.ElementAt(selection).Value);

            int qty = GetOption("\nHow many " + stock.ElementAt(selection).Key.itemName + " ?");
            
            Cart cartItems = new Cart(stock.ElementAt(selection).Key, qty);
            return cartItems.CartItems();
        }

        //DISPLAY SELECTED ITEMS IN CART------------>

        static void Cart(Dictionary<Item, int> itemsInCart, Dictionary<Item,float> price)
        {            
            Console.Clear();
            Console.WriteLine("Cart items\n");
            Console.WriteLine("|-----------------------------------|");
            for (int i = 0; i < itemsInCart.Count; i++)
            {
                Console.WriteLine("      [" + i + "]-" + itemsInCart.ElementAt(i).Key.itemName + " $" + price.ElementAt(i).Value + " Qty: " + itemsInCart.ElementAt(i).Value);
            }
            Console.WriteLine("|-----------------------------------|");
            
        }

        //------------------------------------------^

        //CHECKOUT PROCESS-------------------------->

        static void CheckOutItems(bool finishTransaction)
        {            
            Console.Clear();
            defaultCart.CartItems();

            Console.WriteLine("Checking itmes out\n");

            for (int i = 0; i < defaultCart.CartItems().Count; i++)
            {
                inventory.RemoveStock(defaultCart.CartItems().ElementAt(i).Key, defaultCart.CartItems().ElementAt(i).Value);
                Console.WriteLine(defaultCart.CartItems().ElementAt(i).Value + " " + defaultCart.CartItems().ElementAt(i).Key.itemName + " have been Checked Out\n");
            }
            
            Console.WriteLine("End Of Transaction: " + finishTransaction);
        }

        //------------------------------------------^

        //EXIT APP FUNCTIONS------------------------>

        static bool CheckOut(int checkOut)
        {
            if (checkOut == 1)
            {
                opt = 3;    //Go to cheakout!             
                return true;                
            }
            else
            {
                return false;                
            }
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\nGOOD BYE!\n");
            PressEnter();
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
