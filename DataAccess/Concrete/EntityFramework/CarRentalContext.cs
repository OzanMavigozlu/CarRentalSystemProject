using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IPFQ1B4;Database=MySQLDB;Trusted_Connection=true"); 
        }


        public DbSet<Cars> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<Color> Colors { get; set; }


    }

}
