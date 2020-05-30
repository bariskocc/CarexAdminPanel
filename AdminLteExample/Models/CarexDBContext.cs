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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-3PH96NE;Database=CarexDB;user id=sa;password=c55aajh11;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarPlate)
                    .HasColumnName("car_plate")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.VehicleType)
                    .HasColumnName("vehicle_type")
                    .HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150);

            });

            modelBuilder.Entity<CustomerDetails>(entity =>
            {
                entity.ToTable("customer_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Operation)
                    .HasColumnName("operation")
                    .HasMaxLength(250);

                entity.Property(e => e.OperationCost)
                    .HasColumnName("operation_cost")
                    .HasColumnType("decimal");

                entity.Property(e => e.OperationDate)
                    .HasColumnName("operation_date")
                    .HasColumnType("date");
            });
        }
    }
}
