using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Contexts
{
    internal class AppDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemo02;Trusted_Connection=True;TrustServerCertificate=true");
        }
        DbSet<Models.Student> Students { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var e = modelBuilder.Entity<Models.Empolyee>();

            //e.ToTable("Employees");
            //e.HasKey(emp => emp.Id);

            //e.Property(emp => emp.Name)
            //    .IsRequired()
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .HasColumnName("EmpName");

            //e.Property(emp => emp.Address)
            //    .HasMaxLength(100);
            //e.Property(emp => emp.Salary)
            //    .HasColumnType("decimal(10,2)");

            // another way to configure the entity using Fluent API

            //modelBuilder.Entity<Models.Empolyee>(entity =>
            //{
            //    entity.ToTable("Employees");
            //    entity.HasKey(emp => emp.Id);
            //    entity.Property(emp => emp.Name)
            //        .IsRequired()
            //        .HasColumnType("varchar")
            //        .HasMaxLength(50)
            //        .HasColumnName("EmpName");
            //    entity.Property(emp => emp.Address)
            //        .HasMaxLength(100);
            //    entity.Property(emp => emp.Salary)
            //        .HasColumnType("decimal(10,2)");
            //});

            // third way to configure the entity using a separate configuration class
            // for each class we call here
            modelBuilder.ApplyConfiguration(new Configurations.EmployeeConfiguration());
        }
    }
}
