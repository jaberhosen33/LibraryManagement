using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class LibraryDbContext : DbContext
    {
        
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        // DbSet for each table
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
    
    }
}
