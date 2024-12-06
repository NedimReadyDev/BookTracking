using BookTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTracking.Context
{
    /// <summary>
    /// Representation of database and tables
    /// </summary>
    /// <param name="options"></param>
    public class DatabaseContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<BookNote> BookNotes { get; set; }
    }
}
