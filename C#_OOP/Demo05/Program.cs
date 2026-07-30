using Demo05.Advanced_Interfaces;
using Demo05.Simple_interfaces;
using System.Reflection.Metadata;

namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sealed class

            Parent parent = new Parent();
            parent.Display();
            parent.X=10;

            Child child = new Child();
            child.Display();
            child.X=10;

            GrandChild grandChild = new GrandChild();
            grandChild.Display();   
            grandChild.X=10;

            #endregion

            #region simple Interfaces
            IPrintable print = new Invoice(10,10000);
            
            
            Invoice invoice = new Invoice(10,10000);
            invoice.PrintInfo();

            Report report = new Report("oop", DateTime.Now);
            report.PrintInfo();



            #endregion

            #region Polymorphism

            IShape shape = new Circle(5);

            IShape[] shapes = new IShape[3];
            IShape[] shapes2 = new IShape[]
            {
                new Circle (5) ,
                new Rectangle (5,3),
                new Circle (10)
            };

            double total = 0;

            foreach (IShape shape1 in shapes2)
            {

                total += shape1.Area();

            }

            foreach (IShape shape1 in shapes2) {

                
                PrintInfo(shape1);
            
            }

            Console.WriteLine(total);


            #endregion

            #region Multi implmentation interface

            /**
             class : class => inheritance
             class : interface => implmentation
             interface : interface => inheritance
             class : abstrcat class => inheritance & implementation
             
             
             */
            #endregion


            #region name conflict

            Advanced_Interfaces.Document document = new Advanced_Interfaces.Document();

            ((ICloudStorage)document).save();
            ((ILocalStorage)document).save();

            ILocalStorage local = new Advanced_Interfaces.Document();
            local.save();

            ICloudStorage cloud = new Advanced_Interfaces.Document();
            cloud.save();

            #endregion

            /*
              default implmentation in interface done when i make ref of the interface
            if i made of the class that implment it , it will not appear
            when used ?
            when adding new feature
            common implmentation between classes 
             */
        }

        public static void PrintInfo(IShape shape)
        {
            if (shape == null) return ;

            Console.WriteLine($"{shape.GetType().Name} - Area {shape.Area()} - Perimeter {shape.perimeter()}");

        }
    }
}
