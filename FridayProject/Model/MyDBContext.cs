using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayProject.Model
{
    public class MyDBContext:DbContext
    {

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //MES Development DB
            var connectionStrings = "server=AXCITO-DEV-01;database=FridayDB;User Id=sa;Password=axcito@SQL;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionStrings);
        
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

