using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgrammingAssignments
{

    struct Books
    {
        public enum bookType
        {
            Magazine, Novel, ReferenceBook, Miscellaneous
        }
       
        public string title;
        public int price;
        public int bookId;
        public bookType bookkType;

        public Books(String bTitle, int bPrice, int bbookId, bookType bbk)
        {
            title = bTitle;
            price = bPrice;
            bookId = bbookId;
            bookkType = bbk;
        }

        public string display()
        {
           return $"({title}, {price},{bookId},{bookkType})";
        }
    };
    class StructureAndEnum
    {
        public static void Main()
        {
            Books book = new Books("Shershah", 500, 123, Books.bookType.Miscellaneous);
            Console.WriteLine("The Book Details:");
            Console.WriteLine(book.display());
            Console.ReadLine();
        }
    }
}
