using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_NorthWnd_CodeFirst.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }


    }
}
