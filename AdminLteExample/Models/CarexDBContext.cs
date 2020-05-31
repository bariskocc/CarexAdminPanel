using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdminLteExample.Models
{
    public partial class CarexDBContext : DbContext
    {
        public CarexDBContext()
        {
        }

        public CarexDBContext(DbContextOptions<CarexDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
        public virtual DbSet<CarBrands> CarBrands { get; set; }
        public virtual DbSet<CarModels> CarModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-3PH96NE;Database=CarexDB;user id=sa;password=c55aajh11;");
            }
        }

    }
}
