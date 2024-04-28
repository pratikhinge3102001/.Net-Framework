using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIIDemo
{
    internal class Nullable_BoxingAndUnboxing
    {
        static void Main_Null(string[] args)
        {
            //? and Nullable
            int? a = null;
                     
            Console.WriteLine(a);
            Console.WriteLine(a.HasValue);
            Console.WriteLine(  );
            Nullable<int> b = null;
            Console.WriteLine(b);
            Console.WriteLine(b.HasValue);
            b = 10;
            Console.WriteLine(b.HasValue);
            Console.WriteLine(b.Value);

            Console.WriteLine(a.GetValueOrDefault(100));
            a = 50;
            Console.WriteLine(a.GetValueOrDefault(100));
            Console.WriteLine("----------------");
            //??
            /*
            int? c = null;
            int no = c ?? 10;
            Console.WriteLine("value of c : "+c);
            Console.WriteLine("value of no: "+ no);

            */
           // int? c = null;
            int? c = 400;
            int no = c ??= 10;
            Console.WriteLine("value of c : " + c);
            Console.WriteLine("value of no: " + no);


            //Boxing and unboxing
            int num = 50;
            object obj = num;//boxing
            int num1=(int)obj; //Unbosing


        }
    }
}
