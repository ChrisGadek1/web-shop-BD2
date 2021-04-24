﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD2_projekt{
    public class Products{
        public int ProductsID { get; set; }
        [StringLength(100)]
        public String ProductName { get; set; }
        [StringLength(100)]
        public String ShortDescription { get; set; }
        public String Description { get; set; }
        public int Quantity { get; set; }
        public double price { get; set; }
        public int MeasureUnit { get; set; }
        public StoragePlaces StoragePlace { get; set; }
        public ICollection<Distributors> Distributors { get; set; }
        public ICollection<Invoices> Invoices { get; set; }
    }
}
