using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Student
    {
        public void Display()
        {
            Console.WriteLine($"{Id}-{Name}");
        }

        public partial void PartailMethod(string Name)
        {
            Console.WriteLine("Welcome " + Name);
        }
    }
}
