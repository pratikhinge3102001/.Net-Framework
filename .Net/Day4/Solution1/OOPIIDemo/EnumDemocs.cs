using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    public enum MonthNames
    {
        JAN,
        FEB=34,
        MAR=-1,
        APR=10
    }
    internal class EnumDemocs
    {
        static void Main_enum(string[] args)
        {
            Console.WriteLine(MonthNames.APR);
            Console.WriteLine((int)MonthNames.APR);
        }
    }
}
