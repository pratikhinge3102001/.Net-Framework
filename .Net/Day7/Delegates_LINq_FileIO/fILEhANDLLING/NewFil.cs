using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace fILEhANDLLING
{
    [Serializable]
    internal class NewFil
    {

        public string Name { get; set; }

        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream("new.txt", FileMode.Create, FileAccess.Write))
            {
                "HIeee"

            }
           
            
        }


    }
}
