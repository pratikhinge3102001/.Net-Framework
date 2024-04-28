using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class InvaliNoException:ApplicationException
    {
        public InvaliNoException(string s) {
            Console.WriteLine(s);
        }
    }

    class InvaliNoExceptionDemo
    {
        static void Main(string[] args)
        {
            int magicno = 777;
            int no = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter no: ");
                    no = int.Parse(Console.ReadLine());
                    if (no > magicno)
                        throw new InvaliNoException("No is bigger");
                    else if (no < magicno)
                        throw new InvaliNoException("No is too small");
                }
                catch (InvaliNoException ex)
                {
                                      
                }
                catch { }

            } while (no != magicno);







        }
    }
}
