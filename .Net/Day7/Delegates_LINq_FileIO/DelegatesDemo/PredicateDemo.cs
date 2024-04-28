using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class PredicateDemo
    {
        static void Main_5(string[] args)
        {
            Predicate<int> p = delegate (int no)
            {
                return no > 0;
            };
            Console.WriteLine(p(5));
            Console.WriteLine(p(-15));

            Predicate<string> s= (s1)=>s1.Equals(s1.ToUpper());
            Console.WriteLine(s("HI"));
            Console.WriteLine(s("welcome"));

        }
    }
}
