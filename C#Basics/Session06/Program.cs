using Session06.Enums;// to be able to use enum

namespace Session06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region enum

            Priority pr = Priority.Low;
            Console.WriteLine(pr);// out : Low

            Task task; // allocate 4bytes in stack
            task = new Task(); // allocate memory in heap
            // 4 bytes for int, 4 bytes for string reference, 4 bytes for enum


            task.Id = 1;
            task.Name = "test";
            task.priority = Priority.Medium;// stored in memory as medium with size integer

            Priority pr2 = new Priority();// give default which is as int "0", so return label with value zero
            Console.WriteLine(pr2);// if there is nothing assigned with zero value , so return zero as if we start count from 1

            // as in the form if there are list to choose from low ,med,high , so how ?
            // in that way 
            // we can return the numbers if enum and get the lables of the enum

            int[] nums = (int[])Enum.GetValues(typeof(Priority));// as return Array class not array

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            string[] names = Enum.GetNames(typeof(Priority));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // with if cond

            Season s = Season.Winter;

            if (s == Season.Winter)
                Console.WriteLine("Winter");
            else if (s == Season.Summer)
                Console.WriteLine("Summer");
            else if (s == Season.Spring)
                Console.WriteLine("Spring");
            else
                Console.WriteLine("Unknown");


            // casting from enum to int

            Priority p = Priority.Low;

            //int x = p;// مش ضامن ممكن يكون حاجة غير int
            int x = (int)p;// casting to int
            Console.WriteLine(x);// the int value is stored in db and string appear to user


            // casting from int to enum

            int Num = 1;
            //Priority p2 = Num; //مش ضامن الرقم اللي داخل هيبقي له قيمة و لا لا

            Priority p2 = (Priority)Num;// casting to enum

            int Num2 = 100;

            Priority p3 = (Priority)Num2;// casting to enum but the value is not in the enum so it will return 100 as int value
            // so we need to check if the value is in the enum or not
            // we can use Enum.IsDefined method to check if the value is in the enum or not

            bool flag = Enum.IsDefined(typeof(Priority), Num);
            // typeof (Priority) -> as user defined enum

            if (flag)
            {
                Priority p4 = (Priority)Num;
                Console.WriteLine(p4);
            }

            // enum to string

            Priority Pri = Priority.Low;
            Console.WriteLine(Pri.ToString());


            // string to enum

            string Per = "Low";
            // we will use parse or tryParse

            ////////Priority con = (Priority)Enum.Parse(typeof(Priority), Per);
            // convert to what , convert what ,returns object so customize the parent and convert it to child
            // but that way is bad
            //  as if wrong Per value  , it will throw exception "as not in the enum"
            // the problem of casting from object to priority "unboxing"

            bool Flag = Enum.TryParse(typeof(Priority), Per, out object result);
            Console.WriteLine(Flag);// true , flase
            Console.WriteLine(result);// Low , nothing as object is null

            // that is not better also as i want the return to be priority not object 
            // so we will use generic method

            bool Flag2 = Enum.TryParse<Priority>(Per, out Priority result2);// no need for first parameter
            Console.WriteLine(Flag2);
            Console.WriteLine(result2);


            #endregion

            #region example on enum

            Student std = new Student();// 4 bytes in stack
            // 16 bytes in heap for string , int , enum , enum

            int id;
            bool FLag = false;

            do
            {
                Console.Write("Enter ID :");
                FLag = int.TryParse(Console.ReadLine(), out id);

            } while (!FLag);

            std.Id = id;

            Console.WriteLine("Enter name : ");
            std.Name = Console.ReadLine();

            Gender gender;
            do
            {
                Console.WriteLine("Enter Gender : ");
                FLag = Enum.TryParse(Console.ReadLine(), out gender);


            } while (!FLag);

            std.Gender = gender;

            Branch branch;
            do
            {
                Console.WriteLine("Enter branch : ");
                FLag = Enum.TryParse(Console.ReadLine(), out branch);


            } while (!FLag);

            std.Branch = branch;

            Console.WriteLine(std);// by default it 
                                   // will print toString() method of object class which will return the class name
                                   // as that method is virtual so we can override it in our class to return the values of the properties of the class
                                   //and the impl of cw when it print class it prints its ToString





            #endregion

            #region Array
            //int[] arr = new int[3]; // default 0
            //Console.WriteLine(arr[0]);



            // in memory the stack carries the ref of first element
            //and 3*4 bytes in heap for the 3 elements of the array


            //int[] arr = new int[3] { 1, 2, 3 };
            //int[] arr = new int[] { 1, 2, 3 };

            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            // 2d array

            int[,] Marks =
                new int[3, 5] { { 60,45,84,59,54 },
                                { 78,78,98,87,45},
                                { 78,78,97,87,99} };
            Console.WriteLine(Marks.Length);// whole size
            Console.WriteLine(Marks.GetLength(0));
            Console.WriteLine(Marks.GetLength(1));


            for (int i = 0; i < Marks.GetLength(0); i++)
            {

                for (int j = 0; j < Marks.GetLength(1); j++)
                {
                    Console.Write(Marks[i, j] + " ");
                }
                Console.WriteLine();
            }

            // or 

            // better performance
            // flatten the 2d array to 1d array and print it
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)] + " ");

            }

            #endregion

            #region function
            // function is written in classes or structs
            /*Student std2 = new Student();
            std2.Print();*/

            Student.Print();// static method can be called without creating object of the class

            // func syntax
            // access modifier returnType methodName (parameters)
            #region pass by value
            // value types

            int A = 10;
            int B = 20;
            Console.WriteLine(A);
            Console.WriteLine(B);
            swap(A, B);
            Console.WriteLine("================");
            Console.WriteLine(A);
            Console.WriteLine(B);

            // It did not swap as we passed the values and when we called 
            // method it made stack frame and contains another vars that we swapped having same values
            // but did not swap at all


            // ref types
            int[] Nums = { 1, 2, 3 };
            Console.WriteLine(sumArr(Nums));
            Console.WriteLine(Nums[0]);
            // as we passed value type of address of the array 
            // so two pointers point to it so it changed by that method 
            // but take care if that with string , string apply interning


            #endregion

            #region pass by ref
            // we pass address here


            //value types

            int A2 = 10;
            int B2 = 20;
            Console.WriteLine(A2);
            Console.WriteLine(B2);
            swap(ref A2,ref B2);
            Console.WriteLine("================");
            Console.WriteLine(A2);
            Console.WriteLine(B2); // it responded !!


            // ref types
            int[] Nums2 = { 1, 2, 3 };
            Console.WriteLine(sumArr(ref Nums2));
            Console.WriteLine(Nums2[0]);// no diff in that scenario 

            // lets make a diff
            int[] Nums3 = { 1, 2, 3 };

            Console.WriteLine(sumArr2(Nums3));// sum of method 600 
            Console.WriteLine(Nums3[0]);// 1 of out which not affected

            Console.WriteLine(sumArr2(ref Nums3));// sum of method 600 and out
            Console.WriteLine(Nums3[0]);// 100 in and out


            #endregion

            #region pass out params

            int res1, res2;

            Divide(20, 10, out res1, out res2);
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            // could be made by ref instead of out but to do that we should 
            // intialize res1 and res2 but out it is not mandatory



            #endregion

            #endregion
        }

        static void Divide(int x , int y , out int rem , out int result)
        {
            result = x / y;
            rem = x % y;
        }

        static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static int sumArr(int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        // takes addresses not values !!
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static int sumArr(ref int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }


        // diff
        static int sumArr2(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 100, 200, 300 };
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        static int sumArr2( int[] arr)
        {
            int sum = 0;
            arr = new int[] { 100, 200, 300 };
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }


    }
}

   



