using BookOnShelf.Data.Models;
using BookOnShelf.Models;
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
        public DbSet<Addresses> Addresses { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Fines> Fines { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<BorrowingBooks> BorrowingBooks { get; set; }
        public DbSet<ReservedBooks> ReservedBooks { get; set; }
    }
}
