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

            #region Partitioning

            #region Take - skip
            int[] numbers = { 5, 2, 5, 8, 78, 874, 85, 80, 8, 47, 5, 6, 45, 47 };

            var res5 = numbers.Take(5);
            var res6 = ProductList.OrderByDescending(p => p.UnitPrice).Take(5);
            foreach (var product in res6)
                Console.WriteLine(product);
            res5 = numbers.Skip(5);

            #endregion

            #region TakeWhile-SkipWhile

            #region TakeLast - SkipLast

            #endregion


            #endregion

            #endregion

            #region Quantifiers

            // any

            //var flag = ProductList.Any(); --> is there product at all ?
            //var flag = ProductList.Any(p => p.UnitsInStock == 0); // is there any product out of stock ?)

            //Console.WriteLine(flag);

            // ALL

            var flag = ProductList.Where(p => p.Category == "Seafood")
                                  .All(p => p.UnitsInStock > 0); 
            // Contains

            string[] names = { "Ahmed", "Mona", "Mohamed" };
            bool flag2 = names.Contains("ahmed" , StringComparer.OrdinalIgnoreCase);// implment IEqualityComparer<string> to compare string in case insensitive way

            #endregion


            #region let , into [for query only]

            var res7 = from p in ProductList
                       let DiscPrice = p.UnitPrice * 0.9m
                       where DiscPrice > 10
                       select new { p.ProductName, DiscPrice }; // better for the repeating the code

            var res8 = from p in ProductList
                       select  p.UnitPrice * 0.9m 
                       into DiscPrice
                       where DiscPrice > 10
                       select DiscPrice;
            #endregion

            #region Group By

            #region Example 01 : retervie all products out of stock and group them by category

            var groupOfProducts = ProductList.Where(p => p.UnitsInStock == 0)
                                             .GroupBy(p => p.Category);
            foreach (var group in groupOfProducts)
            {
                Console.WriteLine($"Category : {group.Key} {group.Count()} products");
                foreach (var product in group)
                    Console.WriteLine(product.ProductName);
            }


            #region Example 02 :
            var groupOfProducts2 = ProductList.Where(p => p.UnitsInStock == 0)
                                             .GroupBy(p => p.Category)
                                             .Where(G => G.Count() <= 2)
                                             .Select(G => new { Category = G.Key, Count = G.Count() });

            groupOfProducts2 = from p in ProductList
                               where p.UnitsInStock == 0
                               group p by p.Category
                               into G
                               where G.Count() <= 2
                               select new { Category = G.Key, Count = G.Count() };


            #endregion

            #region EX 03

            string [] Names = { "Ahmed", "Mona", "Mohamed", "Ali", "Hassan", "Hussein" };

            var groupOfNames = Names.GroupBy(n => n[0].ToString(), StringComparer.OrdinalIgnoreCase);

            #endregion


            #endregion


            #endregion

            #region Aggergate 

            #region Count - Longcount

            var count = ProductList.Count();
            count = ProductList.Count(p => p.UnitsInStock == 0);

            var count2 = ProductList.LongCount(p => p.UnitsInStock == 0);

            #endregion

            #region sum

            var products2 = ProductList.GroupBy(p => p.Category)
                                       .Select(g => new { g.Key, totalstock = g.Sum(p => p.UnitsInStock) })
                                       .OrderBy(g => g.totalstock);


            #endregion

            #region MIN MAX AVG

            var min = ProductList.Min(p => p.UnitPrice);
            var minby = ProductList.MinBy(p => p.UnitPrice);
            
            var max = ProductList.Max(p => p.UnitPrice);
            var maxby = ProductList.MaxBy(p => p.UnitPrice);

            var avg = ProductList.Average(p => p.UnitPrice);


            #endregion

            #region Aggergate


            var view = ProductList.Take(5)
                                  .Select(p => p.ProductName)
                                  .Aggregate("",(acc,n) => acc == "" ? n : acc + " , " + n,result=>result.ToUpper());
            #endregion


            #endregion

        }
    }
}
