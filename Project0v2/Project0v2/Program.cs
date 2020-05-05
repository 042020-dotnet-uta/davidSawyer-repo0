using Project0v2.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Project0v2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DBContextClass())
            {
                var clients = new Client();
                clients.FName = "John";
                clients.LName = "Smith";
                clients.UserName = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
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
                            continue;
                        case "2":
                            //search for client by
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
                            OrderMenu();
                            continue;
                        case "2":
                            break;
                        default:
                            continue;
                    }
                    break;
                }
            }
            // Customers place orders to store locations
            // Add a new customer
            // Search customers by name
            
            // Display details of a customers order

            // Display all order history of a store location
            // Display all order history of a customer input validation

            // Location has an inventory

            // Exception handling
            // Persistent data to DB; no hardcoding.	
            // XML comments on all public types and members.
            
            // Inventory decreases when orders are accepted
            // Rejects orders that cannot be fulfilled with remaining inventory 
        }
    }
}
