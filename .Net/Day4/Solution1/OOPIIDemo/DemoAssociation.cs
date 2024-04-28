using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class DemoAssociation
    {
        static void Main_Ass(string[] args)
        {
            Date d= new Date { DD=10,MM=6,YY=1967};
            Person1 person1 = new Person1 { Id=100,Name="xyz",B_date=d};
            Console.WriteLine(person1);
        }
    }
}
