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
    }
}
