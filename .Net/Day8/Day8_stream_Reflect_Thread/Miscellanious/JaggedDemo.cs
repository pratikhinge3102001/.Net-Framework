namespace Miscellanious
{
    internal class JaggedDemo
    {
        static void Main_1(string[] args)
        {
            //Define jagged Array
            int[][] arr = new int[3][];

            //Initialise
            arr[0]=new int[3] {1,2,3};
            arr[1] = new int[] { 1,3,4,5, 2, 3 };
            arr[2] = new int[] { 10, 20 };

            //Display
            foreach (var item in arr)
            {
                foreach (var ele in item)
                {
                    Console.Write(ele + "\t");
                }
                Console.WriteLine();
            }

            int[][] arr2 =
            {
                new int[] { 1,2,3,4,5, 2, 3, },
                new int[] { 10, 20, 30 },
                new int[] { 200, 300}
            };
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            //Display
            foreach (var item in arr2)
            {
                foreach (var ele in item)
                {
                    Console.Write(ele + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
