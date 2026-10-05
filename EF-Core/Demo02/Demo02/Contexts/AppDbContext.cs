using Demo02.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo02.Contexts
{
    internal class AppDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemo02;Trusted_Connection=True;TrustServerCertificate=true");
        }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Empolyee> Empolyees { get; set; }
        public DbSet<Models.Car> Cars{ get; set; }
        public DbSet<Models.CarOpt> CarOpts { get; set; }
        public DbSet<Models.Service> Services { get; set; }
        public DbSet<Models.Customer> Customers { get; set; }

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


            // modelBuilder.ApplyConfigurationsFromAssembly();
            // search for any class that implements IEntityTypeConfiguration<T>  


            ///////////////////////////////////////////////////////
            // another way for one to one mandtory both sides
            // relationship to repersent it 

            modelBuilder.Entity<Models.Car>().ToTable("Employees");
            modelBuilder.Entity<Models.Car>()
                        .HasKey(c => c.EmpId);
            modelBuilder.Entity<Models.Empolyee>()
                        .HasOne(x => x.Car)
                        .WithOne(x => x.Employee)
                        .HasForeignKey<Models.Car>(x => x.EmpId);

            // another way for one optional and one mandatory relationship to repersent it
            modelBuilder.Entity<Models.CarOpt>()
                        .HasOne(x => x.Employee)
                        .WithOne(x => x.CarOpt)
                        .HasForeignKey<Models.CarOpt>(x => x.EmpId)
                        .OnDelete(DeleteBehavior.NoAction); // optional side

            // another way for one to one two optional relationship to repersent it
            modelBuilder.Entity<Models.EmployeeCar>()
                        .HasOne(x => x.Empolyee)
                        .WithOne(x => x.EmployeeCar)
                        .HasForeignKey<Models.EmployeeCar>(x => x.EmployeeId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Models.EmployeeCar>()
                        .HasOne(x => x.Car)
                        .WithOne(x => x.EmployeeCar)
                        .HasForeignKey<Models.EmployeeCar>(x => x.CarId)
                        .OnDelete(DeleteBehavior.Restrict);
            // one to many
            modelBuilder.Entity<Models.Course>()
                        .HasMany(x => x.Students)
                        .WithOne(x => x.Course)
                        .HasForeignKey(x => x.CourseId);
            // many to many
            // first way and that if u want to change the name of table for eg
            // that way we do not have third table to catch 

            //modelBuilder.Entity<Models.Customer>()
            //            .HasMany(x => x.Services)
            //            .WithMany(x => x.Customers)
            //            .UsingEntity(ETB =>
            //            {
            //                ETB.ToTable("CustomerService");
            //                ETB.Property<DateTime>("CreatedAt").HasDefaultValueSql("GETDATE()");
            //                //shadow property , added in column in table but not in c# 
            //            });

            // second way with third table to catch the many to many relationship   
            modelBuilder.Entity<Models.CustomerService>()
                        .HasOne(x => x.Customer)
                        .WithMany(x => x.CustomerServices)
                        .HasForeignKey(x=> x.CustomerId);

            modelBuilder.Entity<Models.CustomerService>()
                        .HasOne(x => x.Service)
                        .WithMany(x => x.ServiceCustomers)
                        .HasForeignKey(x=> x.ServiceId);

            modelBuilder.Entity<Models.CustomerService>()
                        .HasKey(x => new { x.CustomerId, x.ServiceId });

            // self referencing relationship
            modelBuilder.Entity<Models.EmployeeSelf>()
                        .HasOne(x => x.Manager)
                        .WithMany()
                        .HasForeignKey(x => x.ManagerId)
                        .OnDelete(DeleteBehavior.NoAction); // optional side

            modelBuilder.Entity<Customer>(c =>
            {
                c.Property<DateTime>("CreatedAt").HasDefaultValueSql("GETDATE()");
                c.Property<DateTime>("UpdatedAt").HasDefaultValueSql("GETDATE()");
                c.Property<string>("LastModifiedby");
                c.Property<string>("LastCreatedby");
            }
            );

            modelBuilder.Entity<Customer>().OwnsOne(c => c.Address, AB =>
            {
                AB.Property(a => a.City).HasColumnName("City").HasColumnType("varchar").HasMaxLength(50);
                AB.Property(a => a.Street).HasColumnName("Street").HasColumnType("varchar").HasMaxLength(50);
                AB.Property(a => a.Country).HasColumnName("Country").HasColumnType("varchar").HasMaxLength(50);


            });

        }
    }
}
