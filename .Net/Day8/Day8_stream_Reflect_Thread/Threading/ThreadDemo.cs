namespace Threading
{
    internal class ThreadDemo
    {
        static void Main_1(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ThreadState);
            Console.WriteLine(t.Priority);
        }
    }
}
