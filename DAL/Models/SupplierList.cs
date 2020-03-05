using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class SupplierList
    {
        public int Id { get; set; }
        public string SupplierID { get; set; }
        public string ReorderNumber { get; set; }
        public double MinimumOrder { get; set; }
        public double  MasterPackQuantity { get; set; }
        public decimal Price { get; set; }

    }
}
