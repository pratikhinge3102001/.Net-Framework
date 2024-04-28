using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Person:IComparable<Person>
    {
        public Person() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public int CompareTo(Person other)
        {
            return this.Id - other.Id;
        }

        public override string ToString()
        {
            return $"{Id}-{Name}-{city}-{age}";
        }
    }
}
