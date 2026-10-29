using BookManagement.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Api.Data
{
    public class BookManagementDbContext : DbContext
    {
        public BookManagementDbContext(
            DbContextOptions<BookManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}