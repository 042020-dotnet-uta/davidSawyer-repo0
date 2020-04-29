using System;
using System.Collections.Generic;
using System.Text;

namespace Project_0___Store_App
{
    class Order
    {
        private int orderId;
        public int OrderId { get; set; }

        DateTime date = new DateTime();
        public virtual Location StoreId { get; set; }
    }
}
