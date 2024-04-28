using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal interface INewFeatures
    {
        static int data ;
        void Method1();

        //default method
        void Display()
        {
            Console.WriteLine("In Display of Interface");
        }

        //static method
        static void PrintMesg()
        {
            Console.WriteLine("Static Method of Interface");
        }
    }

    class Demo : INewFeatures
    {
        public void Method1()
        {
            Console.WriteLine("Method1 ");
        }
    }
    class DemoOfNewFeature
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.Method1();
            
            INewFeatures inf = demo;
            inf.Display();

            INewFeatures.PrintMesg();
            
        }
    }

}
