using MyEntities;
namespace OOPIIDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Indexer
            CityCollection cityCollection = new CityCollection();
            cityCollection[0] = "Pune";
            cityCollection[1] = "Solapur";
            cityCollection[2] = "Nagpur";
            cityCollection[6] = "Nasik";
            
           
            /*
            Console.WriteLine(cityCollection[0]);
            Console.WriteLine(cityCollection[1]);
            Console.WriteLine(cityCollection[2]);
            Console.WriteLine(cityCollection[5]);
          

            Console.WriteLine(cityCollection["Solapur"]);
            Console.WriteLine(cityCollection["Goa"]);
              */

            //Local Functions
            LocalFunctions localFunctions = new LocalFunctions();
            localFunctions.AllCalculation(5);

        }
    }
}
