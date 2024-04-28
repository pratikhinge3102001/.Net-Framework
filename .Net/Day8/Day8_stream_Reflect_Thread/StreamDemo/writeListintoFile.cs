using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StreamDemo
{
    internal class writeListintoFile
    {
        
            static void Main_2(string[] args)
            {

                //To write the object into the File
                //Step2
                IFormatter formatter = new BinaryFormatter();

                //step3
                using (FileStream fileStream = new FileStream("Person.bin", FileMode.Create, FileAccess.Write))
                {
                    //step4
                    List<Person> persons = new List<Person>();
                    Person person = new Person() { Id = 1, Name = "Keshav", age = 34, city = "Pune" };
                persons.Add(person);
                persons.Add(new Person() { Id = 3, Name = "Xyz", age = 34, city = "Pune" });


                    formatter.Serialize(fileStream, persons);
                    fileStream.Close();
                    Console.WriteLine("Done with writting\n");
                }

                //Read from File
                using (FileStream strm = new FileStream("Person.bin", FileMode.Open, FileAccess.Read))
                {
                    List<Person> ps = (List<Person>)formatter.Deserialize(strm);
                    strm.Close();
                    Console.WriteLine("Person: " );
                foreach (var item in ps)
                {
                    Console.WriteLine(item);
                }
            }

            }
        }
    }
