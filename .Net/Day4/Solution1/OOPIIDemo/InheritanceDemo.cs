using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Emp emp = new Emp(12,"Pqr",new Date { DD=10,MM=12,YY=2001},23456.8f);
            Console.WriteLine(emp);
        }
    }
}
