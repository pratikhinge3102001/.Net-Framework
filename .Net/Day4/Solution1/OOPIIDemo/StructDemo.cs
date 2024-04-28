using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    public struct Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }

        public Person(int id,string nm, string add)
        {
            Id = id;
            Name = nm;
            Address = add;
        }

        public void Display()
        {
            Console.WriteLine($" {this.Id} -{this.Name} -{this.Address}");
        }


    }
    internal class StructDemo
    {
        static void Main_struct(string[] args)
        {
            
            Person person = new Person();
            person.Display();

            //Person person1;
            Person person1 = new Person();
            person1.Name = "xyz";
            person1.Id = 10;
            person1.Address = "Pune";
            person1.Display();

            Person person2 = new Person(12, "abc", "Nasik");
            person2.Display();
        }
    }
}
