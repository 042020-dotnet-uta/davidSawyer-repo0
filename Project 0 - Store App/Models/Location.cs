using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project_0___Store_App
{
    public class Location
    {
        // Location fields
        private int _LocationId;
        [Key]
        public int LocationId
        {
            get { return _LocationId; }
            set { _LocationId = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        List<Licence> licenses = new List<Licence>();
    }
}
