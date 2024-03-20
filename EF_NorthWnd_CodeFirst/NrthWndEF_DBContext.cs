using EF_NorthWnd_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_NorthWnd_CodeFirst
{
    public class NrthWndEF_DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-D2UVJQ0; Database = NrtWND_EF_CodeFirst; trusted_connection =true; trustServerCertificate=true");
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Suppliers>Suppliers { get; set; }
        public DbSet<Employees> Employees { get; set; }

    }
}
