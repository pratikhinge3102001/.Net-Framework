using System.Text.Json;

namespace JsonSerliserDemo
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

        class Program
        {
            static void Main_1(string[] args)
            {
                // Sample object to serialize to JSON
                var person = new Person
                {
                    Id= 1,
                    Name = "Madhura",
                    age = 30,
                    city = "Pune"
                };

                // Path to the file where JSON data will be saved
                string filePath = "output.json";

                // Serialize the object to JSON string
                string jsonString = JsonSerializer.Serialize(person);

                try
                {
                    // Write the JSON string to a file
                    File.WriteAllText(filePath, jsonString);

                    Console.WriteLine("Object serialized and saved to file successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }


