using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class Emp:Person1
    {
        public float Salary {  get; set; }
        public Emp() { Console.WriteLine("Employee default Constructor"); }
        /*
        static Emp() {
            Console.WriteLine("Employee static Constructor");
        }
        */

        public Emp(int id, string name, Date b_date,float sal) : base(id, name, b_date)
        {
            Salary = sal;
        }
        public override string ToString()
        {
            return base.ToString() + " " +Salary    ;
        }
    }
}
