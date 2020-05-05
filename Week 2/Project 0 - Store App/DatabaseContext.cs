using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project0_App
{
    class DatabaseContextClass : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Location> Locations{ get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=pzerov3.db");
    }
}
