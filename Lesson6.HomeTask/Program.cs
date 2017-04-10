using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;

namespace Lesson6.HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //LibraryUser:
            //AddBook
            //RemoveBook
            //BooksCount - count of reserverd book
            //BookInfo - returns book name by index
            //Indexer - returns book index by name
            var user1 = new LibraryUser("Sveta");
            var user2 = new LibraryUser();

            var book1 = new Book
            {
                Name = "First",
                Author = "Vasya",
                Year = 2017
            };

            user1.AddBook(book1);

            user1.AddBook(new Book
            {
                Name = "Second",
                Author = "Vasya",
                Year = 2017
            });

            var bookName = user1.BookInfo(0);
            var book2 = user1["Second"];

            user1.RemoveBook(book1);

        }
    }
}
