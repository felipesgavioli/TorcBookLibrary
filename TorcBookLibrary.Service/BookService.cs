using TorcBookLibrary.Model;
using TorcBookLibrary.Repository;

namespace TorcBookLibrary.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return _repository.GetBookById(id);
        }

        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }

        public void UpdateBook(int id, Book book)
        {
            var existingBook = _repository.GetBookById(id);
            if (existingBook == null)
            {
                throw new KeyNotFoundException("Book not found");
            }

            existingBook.Title = book.Title;
            existingBook.FirstName = book.FirstName;
            existingBook.LastName = book.LastName;
            existingBook.TotalCopies = book.TotalCopies;
            existingBook.CopiesInUse = book.CopiesInUse;
            existingBook.Type = book.Type;
            existingBook.ISBN = book.ISBN;
            existingBook.Category = book.Category;

            _repository.UpdateBook(existingBook);
        }

        public void DeleteBook(int id)
        {
            _repository.DeleteBook(id);
        }

        public IEnumerable<Book> SearchBooks(string searchTerm)
        {
            return _repository.SearchBooks(searchTerm);
        }
    }
}