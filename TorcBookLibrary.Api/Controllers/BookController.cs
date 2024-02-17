using Microsoft.AspNetCore.Mvc;

using TorcBookLibrary.Model;
using TorcBookLibrary.Service;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _service;

    public BookController(IBookService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks()
    {
        return Ok(_service.GetAllBooks());
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(int id)
    {
        var book = _service.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    [HttpPost]
    public ActionResult<Book> PostBook(Book book)
    {
        _service.AddBook(book);
        return CreatedAtAction(nameof(GetBook), new { id = book.BookId }, book);
    }

    [HttpPut("{id}")]
    public IActionResult PutBook(int id, Book book)
    {
        try
        {
            _service.UpdateBook(id, book);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        _service.DeleteBook(id);
        return NoContent();
    }

    [HttpGet("search")]
    public IActionResult SearchBooks(string searchTerm)
    {
        try
        {
            var books = _service.SearchBooks(searchTerm);
            return Ok(books);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }
}