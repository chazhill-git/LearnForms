using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "ILCs cannot exceed 30 characters")]
        public string ItemLookupCode { get; set; }

        [StringLength(30, ErrorMessage = "Item descriptions cannot exceed 30 characters")]
        public string Description { get; set; }

        [StringLength(90, ErrorMessage = "Item descriptions cannot exceed 90 characters")]
        public string ExtendedDescription { get; set; }


        [StringLength(30, ErrorMessage = "Item manufacturer cannot exceed 30 characters")]
        public string Manufacturer { get; set; }
        public int SupplierID { get; set; }

        [StringLength(30, ErrorMessage = "Item model cannot exceed 30 characters")]
        public string Model { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal SupplierCost { get; set; }
        public decimal Cost { get; set; }
        public int DepartmentID { get; set; }
        public int CategoryGroupID { get; set; }
        public int CategoryID { get; set; }
        public string UnitOfMeasure { get; set; }


    }
}
