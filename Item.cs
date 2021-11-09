using System;
using System.Collections.Generic;
using System.Linq;

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
