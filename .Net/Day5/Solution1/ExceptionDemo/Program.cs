namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int no1 = int.Parse(Console.ReadLine());
                int no2 = int.Parse(Console.ReadLine());
                Console.WriteLine(no1 / no2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//OR
                Console.WriteLine("-------------------------");
                Console.WriteLine(ex.ToString());//OR
                Console.WriteLine("-------------------------");
                Console.WriteLine(ex.StackTrace);

            }
        }
    }
}
