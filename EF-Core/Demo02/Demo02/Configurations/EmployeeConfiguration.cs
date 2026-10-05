using Demo02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Configurations
{
    // configuration class for the Employee entity
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Models.Empolyee>
    {
        public void Configure(EntityTypeBuilder<Empolyee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(emp => emp.EmpId);
            builder.Property(emp => emp.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("EmpName");
            builder.Property(emp => emp.Address)
                .HasMaxLength(100);
            builder.Property(emp => emp.Salary)
                .HasColumnType("decimal(10,2)");
            builder.Property(emp => emp.HiringDate)
                //.HasDefaultValueSql("GETDATE()"); // set default value to current date
                .HasDefaultValue(DateTime.Now); // تاريخ الmigration

            builder.Property(emp => emp.Age)
                   .HasDefaultValue(10);

            builder.HasKey(emp => emp.Age);

           
        }
    }
}
