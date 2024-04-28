using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public static int bookcnt;

        public Book() {
            bookcnt ++;
            Console.WriteLine("Default Constructor");
        }

         static Book()
        {
            bookcnt = 0;
            Console.WriteLine("static Constructor");
        }

        static void Main_text(string[] args)
        {
            Console.WriteLine("In Main Method");
            Book book = new Book();
            Book book1 = new Book();
            Book book2 = new Book();
            Console.WriteLine("No of Books Created: "+bookcnt);
        }

    }
}
