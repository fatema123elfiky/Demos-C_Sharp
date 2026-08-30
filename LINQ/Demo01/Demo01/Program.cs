using Demo01.Models;
using System.Collections;
using static Demo01.DataSources.Source;
using Demo01.Helpers;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){ Name = "Ahmed" , Grade=50, Major="CS" },//object initializer
                new Student(){ Name = "Mona" , Grade=60, Major="IS" },
                new Student(){ Name = "Mohamed" , Grade=70, Major="DS" }
            };

            var result = Enumerable.Where(students, s => s.Grade > 50);
            result = students.Where(s => s.Grade > 50);
            foreach (var student in result)
                Console.WriteLine(student.Name);
            var result2 = students.Where(s => s.Grade > 50)
                                  .Select(s => new {s.Name, s.Grade});// anomynous type 
            var Result = new { Name = "ahmed", Id = 2 };
            Console.WriteLine(Result.Name);
            Console.WriteLine(Result.Id);
            Console.WriteLine(Result);// he made override to the tostring
            Console.WriteLine(Result.GetType().Name);// 0'3 , first anoy type , 3 attributes
                                                     // if order changed or name of attributes changed considered new type
            //Result.Id = 20;error
            
            var Result02 = Result with { Id = 50 };

            #region Filtering 

            var products = ProductList;
            var result3 = products.Where(p => p.UnitsInStock > 0 && p.UnitsInStock > 30);
            result3 = from p in products
                      where p.UnitsInStock > 0 && p.UnitsInStock > 30
                      select p;

            foreach (var product in result3)
                Console.WriteLine(product);
            // index overload
            var result4 = products.Where((p, i) => i > 10 && p.UnitsInStock > 0);
            foreach (var product in result4)
                Console.WriteLine(product);



            // oftype
            ArrayList arrayList = new ArrayList() { 
            1,"Ahmed","Mona",2,3,4
            };

            var res = arrayList.OfType<int>();

            #endregion


            #region Projection

            var res2 = ProductList.Where(p => p.UnitsInStock == 0)
                                  .Select(p => new {p.ProductName ,p.ProductID});
            res2 = from p in ProductList
                   where p.UnitsInStock == 0
                   select new { p.ProductName , p.ProductID};

            var res3 = ProductList.Where(p => p.UnitsInStock == 0)
                                  .Select((p,i) => new { p.ProductName, Index =i });
            foreach (var product in res2)
                Console.WriteLine(product);

            var customers = CustomerList.SelectMany(c => c.Orders);
            // another overloading
            var customers2 = CustomerList.SelectMany(c => c.Orders,(c,o) => $"customer : {c.CompanyName} order : {o.OrderID}");

            customers2 = from c in CustomerList
                         from o in c.Orders
                         select $"customer : {c.CompanyName} order : {o.OrderID}";

            foreach (var product in customers)
                Console.WriteLine(product);
            foreach (var product in customers2)
                Console.WriteLine(product);

            #endregion


            #region Ordering

            var re = ProductList.OrderBy(p => p.ProductName);
            foreach (var product in re)
                Console.WriteLine(product);

            string[] words = {"cacxdsc","VBIUbvUB","PGpip;hiIn","OBUhuUNo" };
            var ans = words.OrderBy(w => w, new StringCaseInsensitiveComparer());

            foreach (var word in ans)
                Console.WriteLine(word);
            re = ProductList.OrderBy(P => P.Category).ThenBy(P => P.ProductName);
            foreach (var product in re)
                Console.WriteLine(product);

            re = from p in ProductList
                 orderby p.Category, p.ProductName descending
                 select p;


            #endregion


        }
    }
}
