using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDemo
{
    //Custom Attributes
    class MyCustAttribute:Attribute
    {
        //Write Down Your Logic Here
    }

    [Serializable]
    [MyCustAttribute]
    class Person
    {
        public Person() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Name}-{city}-{age}";
        }
    }
}
