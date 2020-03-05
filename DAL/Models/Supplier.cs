using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public decimal Currency { get; set; }
    }
}
