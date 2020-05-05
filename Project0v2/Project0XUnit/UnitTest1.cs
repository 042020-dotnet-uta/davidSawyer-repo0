using System;
using Xunit;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Project0v2;
using Project0v2.Models;
using System.Linq;

namespace Project0XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var SqLite = new SqliteConnection("Filename=:memory:");
            var DBOptions = new DbContextOptionsBuilder<DBContextClass>().UseSqlite(SqLite).Options;
            SqLite.Open();
            using (var db = new DBContextClass(DBOptions))
            {
                db.Database.Migrate();
                var clients = new Client();
                clients.FName = "John";
                clients.LName = "Smith";
                clients.UserName = "jsmith";
                clients.Password = "asd123";
                db.Add(clients);
                db.SaveChanges();
            }
            using (var db = new DBContextClass(DBOptions))
            {
                var clients = db.Clients
                    .Where(b => b.FName == "John")
                    .OrderBy(b => b.ClientID)
                    .ToList()
                    .First();
                Assert.Equal("John",clients.FName);
            }

        }
    }
}
