namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * //Polymorphism
            Person p = new Person();
            p.Display();

            Emp e = new Emp();
            e.Display();
            Console.WriteLine("-----------------------");
            Person p1 = new Emp();
            p1.Display();

            */
            /*
             * static Demo
             UtilityClass.SendEmail();

             Console.WriteLine("In Main Method");
             Book book = new Book();
             Book book1 = new Book();
             Book book2 = new Book();
             Console.WriteLine("No of Books Created: " + Book.bookcnt);

            //Sealed Demo
             //SealedDemo obj = new SealedDemo();

             //Partial
             Student student = new Student();
             student.Display();
             student.PartailMethod("Rohini");
             */
            //Abstract Demo
            Shape obj = new Circle();
            obj.CalculatePeremeter();
            obj.CalculateArea();

            Circle obj2 = new Circle();
            obj2.CalculatePeremeter();
            obj2.CalculateArea();


        }
    }
}
