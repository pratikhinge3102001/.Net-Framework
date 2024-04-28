using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StreamDemo
{
    internal class AssemblyReflection
    {
        static void Main(string[] args)
        {
            //var ass = Assembly.Load("StreamDemo"); Project Name
            //var ass= Assembly.GetExecutingAssembly();//Current Assembly
            var ass = Assembly.LoadFrom("C:\\Snehal\\CDAC\\Sept 23\\DAC\\.net\\Sept23Demo\\Day6\\CollectionDemo\\bin\\Debug\\net6.0\\CollectionDemo.dll");

            Type[] tarr = ass.GetTypes();
            foreach (Type t in tarr)
            {
                Console.WriteLine("\n\n-----------Type info ----------------------");
                Console.WriteLine("Name: " + t.Name);
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
                Console.WriteLine("--------------------------------");
                Console.WriteLine("All Attributes: \n");
                foreach (var item in t.GetCustomAttributes())
                {
                    Console.WriteLine(item);
                }

            }

        }
    }
}
