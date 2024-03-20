using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_NorthWnd_CodeFirst.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public Suppliers Suppliers { get; set; }
        public int? CategoryID { get; set; }
        public Categories Categories { get; set; }
        [MaxLength(20)]
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReOrderLevel { get; set; }
        public Boolean Discontinued { get; set; }

    }
}
