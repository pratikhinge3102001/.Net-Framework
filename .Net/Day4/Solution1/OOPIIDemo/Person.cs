using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class Person1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Date B_date { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Name}-{B_date}"; 
        }
        public Person1()
        {
            Console.WriteLine("Person COnstructor");
        }
        public Person1(int id, string name, Date b_date)
        {
            Id = id;
            Name = name;
            B_date = b_date;
        }
    }
}
