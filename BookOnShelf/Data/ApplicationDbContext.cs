using BookOnShelf.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<BooksWriters> BooksWriters { get; set; }
        public DbSet<Reserved> Reserved { get; set; }
        public DbSet<BorrowedBooks> BorrowedBooks { get; set; }
        public DbSet<Addresses> addresses { get; set; }
        public DbSet<Genres> genres { get; set; }
        public DbSet<Books> books { get; set; }
        public DbSet<Fines> fines { get; set; }
    }
}
