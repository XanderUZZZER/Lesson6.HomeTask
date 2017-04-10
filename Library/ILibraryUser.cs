namespace Library
{
    public interface ILibraryUser
    {
        int BooksCount { get; }

        void AddBook(Book book);
        void RemoveBook(Book book);
    }
}
