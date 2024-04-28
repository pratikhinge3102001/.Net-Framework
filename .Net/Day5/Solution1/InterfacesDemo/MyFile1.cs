using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    //Explicit Implementation
    internal class MyFile1 : IFileOperation
    {
        string IFileOperation.ReadFile()
        {
            return "Reading Competed";
        }

        void IFileOperation.WriteFile(string data)
        {
            Console.WriteLine("Writing data : "+data);
        }
    }
}
