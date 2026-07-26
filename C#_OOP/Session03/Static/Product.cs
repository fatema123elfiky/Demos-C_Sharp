namespace Session03.Static
{
    internal class Product
    {
       
        public string Name { get; set; }
        public int Id { get; set; }

        public static int Counter { get; set; }


        static Product()
        {
            Counter = 0;
        }

        public Product(int id, string name)
        {
            Counter++;
            Id = id;
            Name = name;
        }

    }
}
