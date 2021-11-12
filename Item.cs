/*Gabriel Medina Pereira
 *Course: COMP2400
  File: Item.cs
  Description: eShop Simulation Object */

namespace eShopSimulator
{
    class Item
    {
        public string itemName;
        public int itemCode;
        

        public Item(string iName, int iCode)
        {            
            itemName = iName;
            itemCode = iCode;
        }

        public override string  ToString()
        {
            return $"{itemName,-10}" + $"{itemCode,-10}";            
        }    

    }
}
