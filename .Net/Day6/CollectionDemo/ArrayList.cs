using System.Collections;

namespace CollectionDemo
{
    
    internal class ArrayListDemo
    {
        static void Main_1(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("arrayList.Capacity :"+arrayList.Capacity);
            arrayList.Add(1);
            arrayList.Add("xyz");
            arrayList.Add(12.5f);
            arrayList.Add("Name");
            Console.WriteLine("arrayList.Capacity :" + arrayList.Capacity);
            arrayList.Add("Pq");
            Console.WriteLine("arrayList.Capacity :" + arrayList.Capacity);
            Console.WriteLine("arrayList.Count :" + arrayList.Count);

            //Display
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //remove Ele
            arrayList.Remove("Name");

            Console.WriteLine( "Removing value");
            //Display
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Insert(2, "element");
            Console.WriteLine("After Insertion at 2 position ");
            //Display
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Index of : "+ arrayList.IndexOf("element"));
        }
    }
}
