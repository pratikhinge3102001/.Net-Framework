using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    //Implicit Implimentation
    internal class MyFileOp : IFileOperation
    {
        public string ReadFile()
        {
            Console.WriteLine("Reading File");
            return "File reading Completed";
        }

        public void WriteFile(string data)
        {
            Console.WriteLine("Writing data to File : "+data);
        }
    }
}
