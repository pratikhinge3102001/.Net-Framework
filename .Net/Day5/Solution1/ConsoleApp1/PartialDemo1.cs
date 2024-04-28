using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student() {
            Id = 10;
            Name = "Rama";
            Console.WriteLine(" Student Constructor");
        }

        public partial void PartailMethod(string Name);
    }
}
