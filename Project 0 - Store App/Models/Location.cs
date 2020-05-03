using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project0_App
{
    public class Location
    {
        // Location fields
        private int _LocationID;
        [Key]
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
        List<Licence> Licenses = new List<Licence>();
        public ICollection<Order> Orders { get; set; }
    }
}
