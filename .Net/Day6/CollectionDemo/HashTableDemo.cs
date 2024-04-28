using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class HashTableDemo
    {
        static void Main_2(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 1);
            ht.Add("Name", "Radha");
            ht.Add("Sal", 34566.89f);

            //Display
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "  "+item.Value);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Check Radha value: "+ ht.ContainsValue("Radha"));
            Console.WriteLine("Check sal key: " + ht.ContainsKey("Sal"));

            //Remove
            ht.Remove("Id");//key
            Console.WriteLine("\n");
            //Display
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            //Only keys
            Console.WriteLine("\n Only Keys: ");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }

            //Only Values
            Console.WriteLine("\n Only VAlues: ");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
