using TorcBookLibrary.Model;

namespace TorcBookLibrary.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(int id);

        void AddBook(Book book);

        void UpdateBook(Book book);

        void DeleteBook(int id);

        IEnumerable<Book> SearchBooks(string searchTerm);
    }
}