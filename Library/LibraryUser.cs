using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class LibraryUser : ILibraryUser
    {        
        private readonly IList<Book> _books;
        public string UserName { get; }
        public int BooksCount => _books.Count;
        //возвращает книгу по имени переданную типу: LibraryUser["BookName"]
        public Book this[string bookName] => _books.First(x => x.Name == bookName);

        public LibraryUser()
        {
            _books = new List<Book>();
        }


        public LibraryUser(string userName)
            :this ()// вызываем вместе с базовыйм конструктором для инициализации массива
        {
            UserName = userName;
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public string BookInfo(int index)
        {
            return _books.ElementAt(index).Name;
        }
    }
}
