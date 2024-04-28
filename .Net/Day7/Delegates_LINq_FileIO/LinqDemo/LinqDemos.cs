+using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
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
    

    internal class LinqDemos
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();
            list.Add(new Person { Id = 1, Name = "Radha", city = "Pune", age = 30 });
            list.Add(new Person { Id = 8, Name = "Rinku", city = "Pune", age = 33 });
            list.Add(new Person { Id = 10, Name = "Ameya", city = "Nasik", age = 34 });
            list.Add(new Person { Id = 3, Name = "Zuber", city = "Satara", age = 20 });
            list.Add(new Person { Id = 4, Name = "Ketki", city = "Prth", age = 21 });

            /*
            //Anonymous Object 
            var res = from p in list
                      select new {No=p.Id,Nm=p.Name };
            foreach (var item in res)
            {
                Console.WriteLine(item.No + " "+ item.Nm);
            }

            Console.WriteLine("==========================");
            //Method
            var res2 = list.Select(p => new {Num= p.Id,Age=p.age });
            foreach (var item in res2)
            {
                Console.WriteLine(item.Num + " " + item.Age);
            }
            */

            //Deffered Execution
            /*
            Console.WriteLine("------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ordered------------------");
            var res = (from p in list
                       orderby p.Id
                       select p);     //.ToList();
            Console.WriteLine("Before Adding new Record \n");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            list.Add(new Person() { Id=11,Name="New Record",city="Pune",age=30});
            Console.WriteLine("After Adding new Record");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            */
            //Asparallel

            var data = Enumerable.Range(1, 50);
            var res = data.AsParallel().AsOrdered().Where(x=>x%2 == 0);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");

            //Group By
            var resGroupby = from p in list
                             group p by p.city;
            foreach (var item in resGroupby)
            {
                Console.WriteLine("------");
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }

            var resGroup = list.GroupBy(x => x.city);
            Console.WriteLine("------------------------------");
            foreach (var item in resGroup)
            {
                Console.WriteLine("------");
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }

        }
    }
}
