using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonSerliserDemo
{
 
        class Program1
        {
            static void Main_2(string[] args)
            {
                string filePath = "output.json";

                try
                {
                    // Read the JSON data from the file
                    string jsonString = File.ReadAllText(filePath);

                    // Deserialize JSON string to an object
                    var myObject = JsonSerializer.Deserialize<Person>(jsonString);

                // Display object properties
                Console.WriteLine(myObject);
            }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    

}
