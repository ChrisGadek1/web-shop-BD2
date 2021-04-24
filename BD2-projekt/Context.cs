using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BD2_projekt{
    public class Context:DbContext{
        DbSet<Products> Products { get; set; }
        DbSet<Invoices> Invoices { get; set; }
        DbSet<Users> Users { get; set; } 
        DbSet<Customers> Customers { get; set; }
        DbSet<Distributors> Distributors { get; set; }
        DbSet<StoragePlaces> StoragePlaces { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Datasource=Database");
        }
    }
}
