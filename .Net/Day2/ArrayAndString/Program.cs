namespace ArrayAndString
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string s=Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine("Length of String :"+ s.Length);
            string s1 = new string("SecondString");
            Console.WriteLine($"Concantinated string {s+s1}");
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());

            String s3 = " Welcome ";
            Console.WriteLine(s3.Trim());
            Console.WriteLine(s3.TrimEnd());
            Console.WriteLine(s3.TrimStart());

            Console.WriteLine("Using foreach loop");
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }

            char[] charr=s1.ToCharArray();
            Array.Reverse(charr);
            Console.WriteLine(charr.ToString());
            foreach (var item in charr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            string empty = string.Empty;
            string space = " ";
            Console.WriteLine(string.IsNullOrEmpty(empty));
            Console.WriteLine(string.IsNullOrWhiteSpace(empty));
            Console.WriteLine(string.IsNullOrEmpty(space));
            Console.WriteLine(string.IsNullOrWhiteSpace(space));

            string s5 = "Hello";
            string s6 = "Hello";
            Console.WriteLine(s5==s6);
            Console.WriteLine(s5.Equals(s6,StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(s5.CompareTo(s6));


        }
    }
}
