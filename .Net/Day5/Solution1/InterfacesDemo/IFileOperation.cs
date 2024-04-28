using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal interface IFileOperation
    {
        string ReadFile();
        void WriteFile(string data);
    }
}
