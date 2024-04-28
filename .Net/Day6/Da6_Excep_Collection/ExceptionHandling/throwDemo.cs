using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class throwDemo
    {
        static void Main_2(string[] args)
        {
            try
            {
                int age = int.Parse(Console.ReadLine());
                if (age > 18) {
                    Console.WriteLine("Valid age");
                }
                else {
                    throw new Exception("Invalid Age Exception");
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am always executed");
            }
        }
    }
}
