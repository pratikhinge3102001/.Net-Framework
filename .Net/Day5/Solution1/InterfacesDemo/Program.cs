namespace InterfacesDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Implicit Call
            MyFileOp op = new MyFileOp();
            Console.WriteLine(op.ReadFile());
            op.WriteFile("Welcome students");

            Console.WriteLine("-----------------");
            IFileOperation ifop = new MyFileOp();
            Console.WriteLine(ifop.ReadFile());
            ifop.WriteFile("Writing using interface ref");

            Console.WriteLine("-----------------");
            //Explicit Implementation call
            // MyFile1 fop = new MyFile1(); //
            //Console.WriteLine(fop.ReadFile());// Error can not call method using class obj

            IFileOperation fop = new MyFile1(); //
            Console.WriteLine(fop.ReadFile());
            fop.WriteFile("Writing using explicit implementation");
        }
    }
}
