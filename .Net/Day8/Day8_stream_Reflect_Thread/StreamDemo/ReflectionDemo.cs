using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDemo
{
    internal class ReflectionDemo
    {
        static void Main_1(string[] args)
        {
            Type t = typeof(string);
            Console.WriteLine("Name: "+ t.Name);
            Console.WriteLine("FullName" + t.FullName);
            Console.WriteLine("Assembly : " + t.Assembly);
            Console.WriteLine("BaseType : " + t.BaseType);
            Console.WriteLine("Namespace :" + t.Namespace);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("All Constructors: \n");
            foreach (var item in t.GetConstructors())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("All Methods: \n");
            foreach (var item in t.GetMethods())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("All Properties: \n");
            foreach (var item in t.GetProperties())
            {
                Console.WriteLine(item);
            }
        }
    }
}
