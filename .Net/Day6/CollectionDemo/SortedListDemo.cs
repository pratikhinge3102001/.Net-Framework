using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("Pune", "Mh12");
            sl.Add("Nasik", "Mh15");
            sl.Add("Nigadi", "Mh14");

            //Display
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Check Mh12 value: " + sl.ContainsValue("Mh12"));
            Console.WriteLine("Check Mh12 key: " + sl.ContainsKey("Mh12"));

            //Remove
            sl.Remove("Pune");//key
            Console.WriteLine("\n");
            //Display
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            //Only keys
            Console.WriteLine("\n Only Keys: ");
            foreach (var item in sl.Keys)
            {
                Console.WriteLine(item);
            }

            //Only Values
            Console.WriteLine("\n Only VAlues: ");
            foreach (var item in sl.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
