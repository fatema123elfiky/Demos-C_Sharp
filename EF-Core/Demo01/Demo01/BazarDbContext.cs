using Demo01.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo01
{

    internal class BazarDbContext : DbContext
    {
        // we chain with base the base chain with the paramterized constructor
        // parameterized calls onconfig to connect with database through options it takes
        // so why we did not chain with the parameterized one ?
        // as we could not pass dbcontextoptionbuilder , but when we use json files we will do it !
        public BazarDbContext() : base()
        {

        }

        // take DbContextoptionsBuilder that help me to connect database
        // the connectionstring we pass it here but only for now , but in normal in config files folder app setting
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemo01;Trusted_Connection=True;TrustServerCertificate=true");// we pass here the connection string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
