using Microsoft.EntityFrameworkCore;

using TorcBookLibrary.Model;

public class TorcDbContext : DbContext
{
    public TorcDbContext(DbContextOptions<TorcDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}