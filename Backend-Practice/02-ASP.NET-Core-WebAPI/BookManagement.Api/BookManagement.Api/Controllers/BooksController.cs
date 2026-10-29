using BookManagement.Api.Data;
using BookManagement.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookManagementDbContext _context;

        public BooksController(BookManagementDbContext context)
        {
            _context = context;
        }

        // GET: api/books
        // 從資料庫查詢全部書籍
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            List<Book> books = await _context.Books
                .AsNoTracking()
                .ToListAsync();

            return Ok(books);
        }

        // GET: api/books/1
        // 依編號查詢書籍
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            Book? book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound(new { message = $"找不到編號 {id} 的書籍" });
            }

            return Ok(book);
        }

        // POST: api/books
        // 新增書籍，由資料庫自動產生編號
        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            book.Id = 0;

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetBookById),
                new { id = book.Id },
                book
            );
        }

        // PUT: api/books/1
        // 修改指定書籍
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Book>> UpdateBook(
            int id,
            Book updatedBook)
        {
            if (updatedBook.Id != 0 && updatedBook.Id != id)
            {
                return BadRequest(new { message = "網址編號與資料編號不一致" });
            }

            Book? book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound(new { message = $"找不到編號 {id} 的書籍" });
            }

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Status = updatedBook.Status;

            await _context.SaveChangesAsync();

            return Ok(book);
        }

        // DELETE: api/books/1
        // 刪除指定書籍
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            Book? book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound(new { message = $"找不到編號 {id} 的書籍" });
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}