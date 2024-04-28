using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class DictionaryDemo
    {
        static void Main_3(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //IDictionary<int,string> dic = new SortedList<int,string>();
            dic.Add(1, "Pune");
            dic.Add(5, "Nasik");
            dic.Add(6, "Yevla");
            dic.Add(2, "Aurangabad");
            dic.Add(3, "SambhajiNAgar");
            dic.Add(7, "Satara");

            Console.WriteLine("Dict elements are : \n");
            foreach (KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine(item.Key + " "+item.Value);
            }

            Console.WriteLine(dic.ContainsKey(1));
            Console.WriteLine(dic.ContainsValue("Pune"));
            //Only Keys
            foreach (var item in dic.Keys)
            {
                Console.WriteLine(item);
            }

            //Only Values
            foreach (var item in dic.Values)
            {
                Console.WriteLine(item);
            }



        }
    }
}
