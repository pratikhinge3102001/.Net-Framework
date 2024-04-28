using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace StreamDemo
{
    internal class WriteObjToFile
    {
        static void Main_1(string[] args)
        {

            //To write the object into the File
            //Step2
            IFormatter formatter = new BinaryFormatter();

            //step3
            using(FileStream fileStream = new FileStream("Person.bin", FileMode.Create, FileAccess.Write))
            {
                //step4
                Person person = new Person() { Id=1,Name="Keshav",age=34,city="Pune"};
                formatter.Serialize(fileStream, person);
                fileStream.Close();
                Console.WriteLine("Done with writting\n");
            }

            //Read from File
            using(FileStream strm = new FileStream("Person.bin",FileMode.Open,FileAccess.Read))
            {
                Person p = (Person)formatter.Deserialize(strm);
                strm.Close();
                Console.WriteLine("Person: "+ p);
            }
            
        }
    }
}
