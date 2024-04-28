using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class LocalFunctions
    {
        public void AllCalculation(int data)
        { 
           //Square
           void Square()
            {
                Console.WriteLine($" Square of No {data*data}");
            }

            //Cube
            void Cube()
            {
                Console.WriteLine($" Cube of No {data * data* data}");
            }
            Square();
            Cube();
        }
    }
}
