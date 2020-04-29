using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project_0___Store_App
{
    class Item
    {
        public int itemId { get; set; }
        public int storeId { get; set; }
        public virtual Location StoreId { get; set; }

        private string itemName;
        public string ItemName { get; set; }
        
        private int itemCost;
        public int ItemCost { get; set; }
        
        private int itemStock;
        public int ItemStock { get; set; }
    }
}
