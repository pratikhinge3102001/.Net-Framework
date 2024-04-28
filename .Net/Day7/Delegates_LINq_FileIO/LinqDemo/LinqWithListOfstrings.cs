using System;
using System.Collections.Generic;({{
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class LinqWithListOfstrings
    {
        static void Main_5(string[] args)
        {
            List<string> strings = new List<string>() 
            { "somnath", "Radha", 
                "Rama", "Ovi","Raju","Rakesh","Ramakant",
                "Sudha", 
                "Ashok", "Avani" };
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            /*
             * //Query Syntax
            var res = from s in strings
                      where s.Length> 4
                      select s;
            displaycoll(res);

            //Method
            var res1= strings.Where(s=> s.Length> 4);
            displaycoll(res1);

            //Query Syntax
            var res = from s in strings
                      where s.StartsWith("R")
                      select s;
            displaycoll(res);

            //Method
            var res1= strings.Where(s=> s.StartsWith("R"));
            displaycoll(res1);

            //Query Syntax
            var res = from s in strings
                      where s.EndsWith("a")
                      select s;
            displaycoll(res);

            //Method
            var res1= strings.Where(s=> s.EndsWith("a"));
            displaycoll(res1);


            //Query Syntax
            var res = (from s in strings
                      where s.EndsWith("a")
                      select s).Count();
            Console.WriteLine("Count is : "+res);

            //Method
            var res1= strings.Where(s=> s.EndsWith("a")).Count();
            Console.WriteLine("Count is : " + res1);

            //Query Syntax
            var res = from s in strings
                      orderby s
                      select s;
            displaycoll(res);

            //Method
            var res1 = strings.OrderBy(s => s);
            displaycoll(res1);

            //Query Syntax
            var res = from s in strings
                      orderby s.Length
                      select s;
            displaycoll(res);

            //Method
            var res1 = strings.OrderBy(s => s.Length);
            displaycoll(res1);

            //Query Syntax
            var res = (from s in strings
                      orderby s.Length
                      select s).Take(3);
            displaycoll(res);

            //Method
            var res1 = strings.OrderBy(s => s.Length).Take(3);
            displaycoll(res1);

             */

            //Query Syntax
            var res = (from s in strings
                       where s.StartsWith("R")
                      orderby s.Length
                      select s);
            displaycoll(res);

            //Method
            var res1 = strings.Where(s=>s.StartsWith("R")).OrderBy(s => s.Length);
            displaycoll(res1);
        }

        private static void displaycoll(IEnumerable<string> coll)
        {
            Console.WriteLine("\n");
            foreach (var x in coll)
            {
                Console.WriteLine(x);
            }
        }
    }
}
