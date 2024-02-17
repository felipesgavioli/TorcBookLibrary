using Microsoft.EntityFrameworkCore;

using TorcBookLibrary.Model;

namespace TorcBookLibrary.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly TorcDbContext _dbContext;

        public BookRepository(TorcDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get all books
        public IEnumerable<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        // Get book by ID
        public Book GetBookById(int bookId)
        {
            return _dbContext.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        // Add a new book
        public void AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        // Update an existing book
        public void UpdateBook(Book book)
        {
            _dbContext.Entry(book).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        // Delete a book
        public void DeleteBook(int bookId)
        {
            var book = _dbContext.Books.Find(bookId);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Book> SearchBooks(string searchTerm)
        {
            return _dbContext.Books
                             .Where(b => b.FirstName.Contains(searchTerm) ||
                                         b.LastName.Contains(searchTerm) ||
                                         b.ISBN.Contains(searchTerm) ||
                                         b.Title.Contains(searchTerm) ||
                                         b.Type.Contains(searchTerm) ||
                                         b.Category.Contains(searchTerm))
                             .ToList();
        }
    }
}