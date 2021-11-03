using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Persistence
{
    public interface ILibraryContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
        
    }
}