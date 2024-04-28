using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class ListDemo1
    {
        static void Main_3(string[] args)
        {
           
                var list = new List<string>();
                //List<string> list2 = list.ToList();
                list.Add("A");
                list.Add("B");
                list.Add("Z");
                list.Add("M");
                list.Add("C");
                list.Add("X");
                list.Add("y");
                list.Add("D");
                list.Add("E");
                list.Add("F");
                DisplayList(list);
            list.Sort();
            DisplayList(list);
            list.Reverse();
            DisplayList(list);
            }
             private static void DisplayList(List<string> list)
            {
                //Display 
                Console.WriteLine("\n List ele: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }


