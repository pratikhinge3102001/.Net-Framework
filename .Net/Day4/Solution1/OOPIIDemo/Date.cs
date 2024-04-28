using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class Date
    {
        public int YY { get; set; }
        public int MM  { get; set; }
        public int DD { get; set; }

        public override string ToString()
        {
            return $"{DD}-{MM}-{YY}";
        }
    }
}
