namespace ExceptionHandling
{
    internal class Program
    {
        static void Main_1(string[] args)
        {
            try
            {
                int no = int.Parse(Console.ReadLine());
                int no1 = int.Parse(Console.ReadLine());
                var res = no / no1;
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
