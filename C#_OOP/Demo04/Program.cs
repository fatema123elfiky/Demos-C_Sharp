using Demo04.Binding;
using Demo04.Overriding;
using Demo04.Polymorphism.MethodHidding;
using Demo04.Polymorphism.Overloading;

namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // operator overloading
            Money money1 = new Money(5000, "EG");
            Money money2 = new Money(6000, "EG");

            Money Result = money1 + money2;

            Console.WriteLine(money1);
            Console.WriteLine(money2);
            Console.WriteLine(Result);


            // method hiding
            Cat cat = new Cat("Hanfy");
          // ref      obj
            cat.Eat();
            cat.MakeSound();

            // static polymorphism - compile time - focus on ref not obj


            // method overloading
            Dog dog = new Dog("parker");
            dog.Eat();
            dog.play();

            // another example

            Circle circle = new Circle(10);
            circle.Draw();// static NEW BASED ON REF COMPILE TIME
            Console.WriteLine(circle.Area()); ;// dynamic OVERRIDE BASED ON OBJ RUN TIME

            // Binding
            // Ref from parent point to object from child
            object obj =10 ;

            Parent parent = new Child();

            parent.Greet();
            parent.Introduce();

            //parent.Id -> we could not access as ref is parent not child !!

            // now the importance of binding not to repeat the code at all

            EmailNotification email = new EmailNotification("fatema@gmail.com", "hello fatema");
            send(email);

            SMSNotification sms = new SMSNotification("hello route", "1201214502");
            send(sms);
            // here is the advantage the function is not repeated by making parameter recievs any of children
            // by  making the ref of parameter to be parent 


        }

        public static void send(Binding.Notification notifcation)
        {
            notifcation.Send();
        }
    }

    
}
