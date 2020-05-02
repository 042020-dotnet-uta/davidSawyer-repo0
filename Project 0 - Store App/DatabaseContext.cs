using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project_0___Store_App
{
    class DBContextClass : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Location> Locations{ get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=pzerov2.db");
    }
}
