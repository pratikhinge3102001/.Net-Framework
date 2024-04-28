namespace DelegatesDemo
{
    //step1
    //Declaration 
    public delegate void Mydel(int a, int b);
    public delegate string StringDel(string s);

    internal class SingleCastDelegateDemo
    {
        public static void Add(int a, int b) {
            Console.WriteLine(a+b);
        }

        public string Print(string s)
        {
            return s.ToUpper();
        }

        static void Main_1(string[] args)
        {
            //Step2
            //1 way
            //Mydel d = Add;
            //2nd 
            Mydel d = new Mydel(Add);
            SingleCastDelegateDemo d2 = new SingleCastDelegateDemo();
            StringDel d1 = d2.Print;

            //step3
            d(12, 34);
            //or
            d.Invoke(4, 5);


            string s = d1.Invoke("hi");
            Console.WriteLine(s);
            Console.WriteLine(d1("welcome"));


        }
    }
}
