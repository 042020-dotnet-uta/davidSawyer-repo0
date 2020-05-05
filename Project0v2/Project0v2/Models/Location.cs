using System;
using System.Collections.Generic;
using System.Text;

namespace Project0v2.Models
{
    public class Location
    {
        // Location fields
        private int _LocationID;

        public int LocationID
        {
            get { return _LocationID; }
            set { _LocationID = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        //List<Licence> Licenses = new List<Licence>();
        public virtual ICollection<Order> Orders { get; set; }
        public Location() { }
    }
}
