using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fILEhANDLLING
{
    [Serializable]
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }  

        public Person() { }
        public Person(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }

    }
}
