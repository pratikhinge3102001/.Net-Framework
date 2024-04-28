namespace FileIO
{
    internal class FileOP
    {
        static void Main_1(string[] args)
        {
            /*
            string s = "Welcome to Know It";
            //Write To File
            File.WriteAllText("Mydata.txt", s);
            Console.WriteLine("Done");

            //Read File
            string s1 = File.ReadAllText("Mydata.txt");
            Console.WriteLine(s1);
            */
            string[] strings = {"somnath", "Radha",
                "Rama", "Ovi","Raju","Rakesh","Ramakant",
                "Sudha",
                "Ashok", "Avani" };
            File.WriteAllLines("Mydata1.txt", strings);
            string[] strings2 = File.ReadAllLines("Mydata1.txt");
            
            int cnt = 0;
            foreach (string s in strings2)
            {
                Console.WriteLine(++cnt + ". " +s);
            }

            Console.WriteLine(File.Exists("Mydata1.txt"));
            File.Copy("Mydata1.txt", "Mydata2.txt",true);
            Console.WriteLine("Done with copying....");
    
            File.AppendAllText("Mydata2.txt", "Done with writting");


        }
    }
}
