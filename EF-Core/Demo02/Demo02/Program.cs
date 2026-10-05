using Demo02.Contexts;
using Demo02.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            var customers = context.Customers.FirstOrDefault();

            #region CRUD OPerations
                    var customer = new Customer
                    {
                        Name = "John Doe",
                        Address = new Address
                        {
                            Street = "123 Main St",
                            City = "Anytown",
                            Country = "USA"
                        }

                    };

            #region Add
            Console.WriteLine(context.Entry(customer).State);// detached , no relationship
            context.Customers.Add(customer);// first way of add
                                            // adding is about changing status to let change tracker feel it 
            context.Add(customer);// second way of add
            context.Set<Customer>().Add(customer);// third way of add
            context.Entry(customer).State = EntityState.Added;// fourth way of add

            Console.WriteLine(context.Entry(customer).State);

            context.SaveChanges();

            Console.WriteLine(context.Entry(customer).State);

            #endregion
            // add range to add list instead of forloop

            #region Read

            // apply linq as we used to do in c# to get data from database
            // that is request to get all customers from database and return them as list
            var customers2 = context.Customers.ToList();// we changed dbset to list to be easy used  acc to my use
            foreach (var item in customers2)
            {
                Console.WriteLine(item.Name);
            }

            // return queryable
            var customers3 = context.Customers.Where(c => c.Id == 1);//request
            var customers4 = context.Customers.FirstOrDefault(c => c.Id == 1);// request
            var customers5 = context.Customers.Find(1);// find on id directly , but find locally on data local then databse

            // load everything in table as select *
            context.Customers.Load();
            var load = context.Customers.Local;

            // means no tracking to let change tracker do not care about it 
            // why to less the performance of change tracker as we just read
            // so state is detached and no need to track it
            var customers6 = context.Customers.AsNoTracking().FirstOrDefault(c => c.Id == 1);

            #endregion

            #region Update-delete
            var customer2 = context.Customers.FirstOrDefault(c => c.Id == 1);
            Console.WriteLine(context.Entry(customer2).State);// unchanged
            customer2.Name = "Jane Doe";
            // to make update manaully change state
            context.Update(customer2);// with the change upwards 
            Console.WriteLine(context.Entry(customer2).State);// modified
            context.SaveChanges();
            Console.WriteLine(context.Entry(customer2).State);// unchanged

            Console.WriteLine(context.Entry(customer2).State);// unchanged
            context.Remove(customer2);
            Console.WriteLine(context.Entry(customer2).State);// deleted
            context.SaveChanges();
            Console.WriteLine(context.Entry(customer2).State);// Detached


            #endregion

            #endregion

            

        }
    }
}
