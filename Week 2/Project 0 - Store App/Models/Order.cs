﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project0_App
{
    public class Order
    {
        [Key]
        private int _OrderID;

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

        // Order details
        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        private decimal _Price;

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

       // DateTime date = new DateTime();
        // Parameters from other classes
        [ForeignKey("Location")]
        public virtual Location LocationID { get; set; }
        //[ForeignKey("Client")]
        //public virtual Client ClientID { get; set;}
        [ForeignKey("Licence")]
        public virtual Licence LicenceID { get; set; } 
        #region Menus
        // Create new order
      /*  private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Make a new order");
            Console.WriteLine("2) Modify an order");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    AddOrder();
                    return true;
                case "2":
                    EditOrder();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void AddOrder()
        {
            Licence addItem = new Licence();
            Console.Clear();
            Console.WriteLine("Choose the item that you would like to order:");
            //list of items available for sale by number
        }
        private static void EditOrder()
        {
        } */
        #endregion
    }
}
