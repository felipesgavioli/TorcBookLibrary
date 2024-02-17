using TorcBookLibrary.Model;

namespace TorcBookLibrary.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(int id);

        void AddBook(Book book);

        void UpdateBook(int id, Book book);

        void DeleteBook(int id);

        IEnumerable<Book> SearchBooks(string searchTerm);
    }
}