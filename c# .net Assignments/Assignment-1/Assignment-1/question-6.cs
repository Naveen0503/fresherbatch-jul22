using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace q6
{
    public struct Book
    {
        public int bookId;
        public string title;
        public int price;

        public enum bookType
        {
            Magazine = 1,
            Novel = 2,
            ReferenceBook = 3,
            Miscellaneous = 4
        }


        public static void Details()
        {
            Console.WriteLine("enter no.of books");
            int size = int.Parse(Console.ReadLine()); 
            Book[] books = new Book[size];
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("-------Accepting the details-------");

                Console.WriteLine("Enter the bookId:");
                int bookID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Book Title:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the Book Price:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Book Type in Code:");
                int code = int.Parse(Console.ReadLine());
   
                Console.WriteLine("-------Displaying the details-------");

                Console.WriteLine("The bookId is: {0}", bookID);
                Console.WriteLine("The Book Title is: {0}", title);
                Console.WriteLine("The Book Price is: {0}", price);
                Console.WriteLine("The Book Type is: {0}", (bookType)code);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book.Details();
            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.GetType().Name);
            }
        }
    }
}