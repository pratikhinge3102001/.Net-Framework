using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntities
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public override string? ToString()
        {
            return $"{Id}-{Name}-{Salary}-{Address}-{City}";
        }
    }
}
