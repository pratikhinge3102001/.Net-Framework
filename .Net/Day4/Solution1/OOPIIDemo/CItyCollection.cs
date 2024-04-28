using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class CityCollection
    {
        string[] cities = new string[5];

        public string this[int index]
        {
            get
            {
                if(index >=0 && index< cities.Length) { 
                return cities[index];
                }
                else
                {
                    return "Out of index";
                }
            }
            set
            {
                if (index >= 0 && index < cities.Length)
                {
                    cities[index] = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
                
            }
        }

        public int this[string cty]
        {
            get
            {
                for(int i = 0; i < cities.Length; i++)
                {
                    if (cities[i] == cty)
                        return i;
                }
                return -1;
               
            }
            
        }
    }
}
