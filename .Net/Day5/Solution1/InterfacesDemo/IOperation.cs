using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    //Interface Inheritance
    internal interface IOperation
    {
        void Method1();
    }
    interface IStringOperation:IOperation
    {
        void Method2();
        void Method3();
    }

    class MyOperations:IStringOperation
    {
        public void Method1() {
            Console.WriteLine("Method 1");
        }
        public void Method2() {
            Console.WriteLine("Method 2");
        }
        public void Method3() {
            Console.WriteLine("Method ");
        }
    }

    interface IMathOperation
    {
        void Method4();
    }

    //Class with Multiple Interfaces
    class MathOperation : IOperation, IMathOperation
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}
