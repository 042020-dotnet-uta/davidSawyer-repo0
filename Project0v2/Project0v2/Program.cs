using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Project0v2.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Project0v2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a starting menu:");
                Console.WriteLine("1) Order Menu");
                Console.WriteLine("2) Client Menu");
                Console.WriteLine("3) Inventory");
                Console.WriteLine("4) Exit");
                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        OrderMenu();
                        continue;
                    case "2":
                        ClientMenu();
                        continue;
                    case "3":
                        InvMenu();
                        continue;
                    case "4":
                        break;
                    default:
                        continue;
                }
                break;
            }
            static void OrderMenu() {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1) Add new order");
                    Console.WriteLine("2) Edit existing order");
                    Console.WriteLine("3) View order history");
                    Console.WriteLine("4) Exit");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //Call the order creation
                            NewOrder();
                            continue;
                        case "2":
                            //Pull orders from DB
                            continue;
                        case "3":
                            OrderHistory();
                            continue;
                        case "4":
                            break;
                        default:
                            continue;
                    }
                    break;
                }
            }
            static void OrderHistory()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("View History by:");
                    Console.WriteLine("1) Store");
                    Console.WriteLine("2) Client");
                    Console.WriteLine("3) Exit");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //use store history
                            continue;
                        case "2":
                            //use client history
                            continue;
                        case "3":
                            break;
                        default:
                            continue;
                    }
                    break;
                }
            }
            static void ClientMenu() {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1) Add a client");
                    Console.WriteLine("2) Search client list");
                    Console.WriteLine("3) Exit");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //add person function
                            NewClient();
                            continue;
                        case "2":
                            //search for client by name
                            FindClient();
                            continue;
                        case "3":
                            break;
                        default:
                            continue;
                    }
                    break;
                }
            }
            static void InvMenu() {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Choose a starting menu:");
                    Console.WriteLine("1) View store inventory");
                    Console.WriteLine("2) Exit");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            // view store inventory
                            StoreInv();
                            continue;
                        case "2":
                            break;
                        default:
                            continue;
                    }
                    break;
                }
            }
            
            // Display details of a customers order
            // Display all order history of a store location
            // Display all order history of a customer input validation
            // Exception handling
            // XML comments on all public types and members.
            // Inventory decreases when orders are accepted
            // Rejects orders that cannot be fulfilled with remaining inventory 
        }
        // Add a new customer
        private static void NewClient()
        {
            using (var db = new DBContextClass())
            {
                Console.Clear();
                var clients = new Client();
                Console.WriteLine("First Name:");
                clients.FName = Console.ReadLine();
                Console.WriteLine("Last Name:");
                clients.LName = Console.ReadLine();
                Console.WriteLine("UserName:");
                clients.UserName = Console.ReadLine();
                Console.WriteLine("Password:");
                clients.Password = Console.ReadLine();
                db.Add(clients);
                db.SaveChanges();
            }
        }
        // Search customers by name
        private static void FindClient()
        {
            using (var db = new DBContextClass())
            {
                Console.WriteLine("First Name:");
                var clients = db.Clients
                    .Where(b => b.FName == Console.ReadLine())
                    .OrderBy(b => b.ClientID)
                    .ToList()
                    .First();
                Console.WriteLine($"{clients.FName} {clients.LName}");
                Console.ReadLine();
            }
        }
            
        
        private static void NewOrder()
        {
            using (var db = new DBContextClass())
            {
                var orders = new Order();
                //int locAdj;
                Console.WriteLine("We have locations in \n1) New York\n2) Austin\n3) Detroit.\nType the number of the location you would like order from:");
                /*switch (Console.ReadLine())
                {
                    case "1":
                        locAdj = 0;
                        LicenceLogic();
                        break;
                    case "2":
                        locAdj = 3;
                        LicenceLogic();
                        break;
                    case "3":
                        locAdj = 6;
                        LicenceLogic();
                        break;
                    default:
                        break;
                }
                void LicenceLogic()
                {*/
                    var licences = db.Licences
                        .FromSqlRaw($"Select * from Licences where LocationID = {Console.ReadLine()};")
                        .ToList();
                    foreach (Licence value in licences)
                    {
                        Console.WriteLine(value);
                    }
                    Console.WriteLine($"Type the number of the licence you would like to purchase:");
                    var licence = db.Licences
                        .FromSqlRaw($"Select * from Licences where LicenceID = {Console.ReadLine()};")
                        .ToList();
                    Console.WriteLine("Type the quantity of licences you would like to purchase:");
                    int quan = Int32.Parse(Console.ReadLine());
                    if (quan < 10)
                    {
                        Console.WriteLine("Your purchase was successful.");
                    }
                    else
                    {
                        Console.WriteLine("There aren't that many available to buy.");
                    }
                //}
            }
        }
        // Location has an inventory
        private static void StoreInv()
        {
            using (var db = new DBContextClass())
            {
                
                Console.WriteLine("We have locations in \n1) New York\n2) Austin\n3) Detroit.\nType the number of the location you would like to view:");
                var licences = db.Licences
                    .FromSqlRaw($"Select * from Licences where LocationID = {Int32.Parse(Console.ReadLine())};")
                    .ToList();
                foreach (Licence value in licences)
                {
                    Console.WriteLine(value);
                }
                Console.ReadLine();      
            }
        } 
    }
}
// Persistent data to DB; no hardcoding. - Complete