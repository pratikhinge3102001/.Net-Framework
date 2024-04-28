namespace LinqDemo
{
    internal class LinqWithArray
    {
        static void Main_6(string[] args)
        {
            int[] arr = { 10, 23, 5, 6, 7, 1, 2, 3 };
            /*
            //Linq Query Syntax
            var res = from x in arr
                      where x > 5
                      select x;
            Console.WriteLine("Orignal array: ");
            displayarray(arr);
            Console.WriteLine("-----------result:");
            displayarray(res);
            var res1 = (from x in arr
                        where x > 5
                        select x).Count();

            Console.WriteLine("Count: ");
            Console.WriteLine(res1);
            //Linq Method Syntax
            Console.WriteLine("Method Syntax: ");
            var res2 = arr.Where(x => x > 5);
            displayarray(res2);

            var res3 = arr.Where(x => x > 5).Count();
            Console.WriteLine("Count :" +res3);

            //Linq Query Syntax
            var res = from x in arr
                      where x > 5 && x < 20
                      select x;
            Console.WriteLine("Orignal array: ");
            displayarray(arr);
            Console.WriteLine("-----------result:");
            displayarray(res);
            var res1 = (from x in arr
                        where x > 5 && x < 20
                        select x).Count();

            Console.WriteLine("Count: ");
            Console.WriteLine(res1);
            //Linq Method Syntax
            Console.WriteLine("Method Syntax: ");
            var res2 = arr.Where(x => x > 5 && x<20);
            displayarray(res2);

            var res3 = arr.Where(x => x > 5 && x<20).Count();
            Console.WriteLine("Count :" + res3);
            
             //Linq Query Syntax
            var res = from x in arr
                      orderby  x
                      select x;
            Console.WriteLine("Orignal array: ");
            displayarray(arr);
            Console.WriteLine("-----------result:");
            displayarray(res);
            
            
            //Linq Method Syntax
            Console.WriteLine("Method Syntax: ");
            var res2 = arr.OrderBy(x => x);
            displayarray(res2);
             */

            //Linq Query Syntax
            var res = from x in arr
                      orderby  x descending
                      select x;
            Console.WriteLine("Orignal array: ");
            displayarray(arr);
            Console.WriteLine("-----------result:");
            displayarray(res);
            
            
            //Linq Method Syntax
            Console.WriteLine("Method Syntax: ");
            var res2 = arr.OrderByDescending(x => x);
            displayarray(res2);

            


        }

        private static void displayarray(IEnumerable<int> arr)
        {
            Console.WriteLine("\n");
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
