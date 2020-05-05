using System;
using System.Collections.Generic;
using System.Text;

namespace Project0v2.Models
{
    public class Licence
    {
        // Item fields
        private int _LicenceID;
        
        public int LicenceID
        {
            get { return _LicenceID; }
            set { _LicenceID = value; }
        }

        private string _Company;

        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }

        private decimal _Price;

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public Location Location { get; set; }
        List<Licence> Licenses = new List<Licence>();
        public virtual ICollection<Order> Orders { get; set; }
    }
}
