using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Project0v2.Models;

namespace Project0v2
{
    public class DBContextClass : DbContext
    { 
        public DbSet<Client> Clients { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured) options.UseSqlite("Data Source=projectZero.db");
        }
            
        public DBContextClass(DbContextOptions<DBContextClass> Options) : base(Options) { }
    }
}
