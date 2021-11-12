/*Gabriel Medina Pereira
 *Course: COMP2400
  File: Cart.cs
  Description: eShop Simulation Object */

using System.Collections.Generic;

namespace eShopSimulator
{
    class Cart
    {
        static Item cartItem;
        static int cartStock;
        static public Dictionary<Item, int> cartItems = new Dictionary<Item, int>();

        public Cart() : this(cartItems)
        {

        }

        public Cart(Dictionary<Item,int> cart)
        {
            Cart.cartItems = cart;
        }

        public Cart(Item item, int qty)
        {
            cartItem = item;
            cartStock = qty;
            AddItemToCart(item, qty);
        }

        public void RemoveItemFromCart(Item item, int qty)
        {
            //Verificar si existe el key 
            if (cartItems.ContainsKey(item))
            {
                cartItems[item] -= qty;
            }
            else
            {
                cartItems.Remove(item);
            }
        }
        
        public void AddItemToCart(Item item, int qty)
        {
            //Verificar si existe el key 
            if (cartItems.ContainsKey(item))
            {
                cartItems[item] += qty;
            }
            else
            {
                cartItems.Add(item, qty);
            }
        }

        public Dictionary<Item, int> CartItems()
        {
            return cartItems;
        }
    }
}
