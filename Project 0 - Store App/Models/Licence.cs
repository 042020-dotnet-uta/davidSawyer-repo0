using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Project_0___Store_App
{
    public class Licence
    {
        // Item fields
        private int _LicenceId;
        [Key]
        public int LicenceId
        {
            get { return _LicenceId; }
            set { _LicenceId = value; }
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


        // Add new item modifeied from https://wellsb.com/csharp/beginners/create-menu-csharp-console-application/)
        #region Menu
        static void AddItem(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add an item");
            Console.WriteLine("2) Edit an item");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    AddItem();
                    return true;
                case "2":
                    EditItem();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void AddItem()
        {
            Licence addItem = new Licence();
            Console.Clear();
            Console.WriteLine("What's the name of the item?");
            addItem.Company= Console.ReadLine();
            Console.WriteLine("What's the cost of the item?");
            addItem.Price = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("What's the current stock of the item?");
            addItem.Quantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"\r\n{addItem.Company} has been added, with a cost of {addItem.Price} and an initial stock of {addItem.Quantity} ");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
        // Change stock of item    
        private static void EditItem()
        {
            /*                    Item addItem = new Item();
                                Console.Clear();
                                Console.WriteLine("What's the name of the item?");
                                addItem.ItemName = Console.ReadLine();
                                Console.WriteLine("What's the cost of the item?");
                                addItem.ItemCost = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                                Console.WriteLine("What's the current stock of the item?");
                                addItem.ItemStock = Int32.Parse(Console.ReadLine());
                                Console.WriteLine($"\r\n{addItem.ItemName} has been added, with a cost of {addItem.ItemCost} and an initial stock of {addItem.ItemStock} ");
                                Console.Write("\r\nPress Enter to return to Main Menu");
                                Console.ReadLine();*/
        } 
        #endregion
    }
 }
    
