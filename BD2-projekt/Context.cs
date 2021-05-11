using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BD2_projekt{
    public class Context:DbContext{
        public DbSet<Products> Products { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Users> Users { get; set; } 
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Distributors> Distributors { get; set; }
        public DbSet<StoragePlaces> StoragePlaces { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Datasource=Database");
        }
    }
}
