Mydatausing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class DirectoryDemo
    {
        static void Main(string[] args)
        {
            string dpath = "C:\\Ravi";// @"c:\Ravi"

            if(Directory.Exists(dpath))
            {
                Console.WriteLine("All Files: \n");
                foreach (var item in Directory.GetFiles(dpath))
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n All Directories: \n");
                foreach (var item in Directory.GetDirectories(dpath))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
