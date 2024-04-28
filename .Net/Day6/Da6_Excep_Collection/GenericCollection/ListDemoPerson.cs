using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class ListDemoPerson
    {
        static void Main_p(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person());
            list.Add(new Person { Id=1,Name="Radha",city="Pune",age=30});
            list.Add(new Person { Id = 8, Name = "Radha", city = "Pune", age = 30 });
            list.Add(new Person { Id = 10, Name = "Ameya", city = "Nasik", age = 34 });
            list.Add(new Person { Id = 3, Name = "Zazu", city = "Satara", age = 20 });
            Console.WriteLine("\n Before Sorting: ");
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }

            list.Sort();
            Console.WriteLine("\n After Sorting: ");
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }

            PersonAgeComparer ageComparer = new PersonAgeComparer();
            list.Sort(ageComparer);
            Console.WriteLine("\n After age Sorting: ");
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }


            PersonNameComparer nameComparer = new PersonNameComparer();
            list.Sort(nameComparer);
            Console.WriteLine("\n After Name Sorting: ");
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }

        }
    }
}
