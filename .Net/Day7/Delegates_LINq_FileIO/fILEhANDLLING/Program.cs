using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace fILEhANDLLING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(57,"sushant","city");


            IFormatter formatter = new BinaryFormatter();
            //creating file object

            using (FileStream f1 = new FileStream("Person.txt", FileMode.Create, FileAccess.Write))
            {

                formatter.Serialize (f1, person);
                f1.Close ();
                Console.WriteLine("Done");
            }
        }
    }
}
