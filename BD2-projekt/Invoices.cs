using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD2_projekt
{
    public class Invoices{
        public int InvoicesID { get; set; }
        public Customers Customer { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<OrderUnit> Products { get; set; }
    }
}
