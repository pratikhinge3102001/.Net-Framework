namespace GenericCollection
{
    class Demo<T> //where T:IComparable  where T:struct  where T:class
    {
        public T data { get; set; }
        public Demo(T d) {
        data = d;
        }
        public void Display()
        {
            Console.WriteLine("Data is :"+data);
        }

        
       

    }

    class Demo1
    {
        public void Add<T1>(T1 a, T1 b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
           // Console.WriteLine(a+b); 


        }
    }
    internal class GenericClass
    {
        static void Main_2(string[] args)
        {
            Demo<int> d = new Demo<int>(5);
            d.Display();

            Demo<float> d1 = new Demo<float>(25.6f);
            d1.Display();

            Demo<string> d2 = new Demo<string>("Welcome");
            d2.Display();

            Demo<Person> dperson = new Demo<Person>(new Person { Id=3,Name="PQr"});
            dperson.Display();

            Demo1 demo2 = new Demo1();
            demo2.Add<int>(3, 78);

        }
    }
}
