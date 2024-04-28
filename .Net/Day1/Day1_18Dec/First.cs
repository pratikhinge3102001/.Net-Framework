using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_18Dec
{
   
    internal class First
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter Id, name, marks");
            int id = int.Parse(Console.ReadLine());
            string name=Console.ReadLine();
            float marks=float.Parse(Console.ReadLine());

            //Display the Output
            Console.WriteLine("Id "+ id+" name "+name+ " marks "+marks);
            Console.WriteLine("Id {0} name {1} marks {2} ",id,name,marks);
            Console.WriteLine($"Id {id} name {name} marks {marks} ");

        }
    }
}
