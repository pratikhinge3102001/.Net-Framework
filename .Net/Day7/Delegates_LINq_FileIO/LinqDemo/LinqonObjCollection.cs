using LinqDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
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

    
internal class LinqonObjCollection
    {
        static void Main_5(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Id = 1, Name = "Radha", city = "Pune", age = 30 });
            list.Add(new Person { Id = 8, Name = "Rinku", city = "Pune", age = 33 });
            list.Add(new Person { Id = 10, Name = "Ameya", city = "Nasik", age = 34 });
            list.Add(new Person { Id = 3, Name = "Zuber", city = "Satara", age = 20 });
            list.Add(new Person { Id = 4, Name = "Ketki", city = "Prth", age = 21 });
            DisplayObjectColl(list);

            /*
             *  //Query
            var res = from p in list
                      where p.city == "Pune"
                      select p;
            DisplayObjectColl(res);

            //Method
            var res2 = list.Where(p => p.city == "Pune");
            DisplayObjectColl(res2);

            //Query
            var res = from p in list
                      orderby p.Name
                      select p;
            DisplayObjectColl(res);

            //Method
            var res2 = list.OrderBy(p => p.Name);
            DisplayObjectColl(res2);

             */

            //Query
            var res = from p in list
                      where p.city == "Pune"
                      select p.Name;
            DisplayObjectColl(res);

            //Method
            var res2 = list.Where(p => p.city=="Pune").Select(p=>p.Name);
            DisplayObjectColl(res2);
        }

        private static void DisplayObjectColl(IEnumerable<string> res)
        {
            Console.WriteLine("---------------\n");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        private static void DisplayObjectColl(IEnumerable<Person> list)
        {
            Console.WriteLine("---------------\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
