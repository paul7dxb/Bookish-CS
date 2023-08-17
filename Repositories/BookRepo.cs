using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories;


public class BookRepo
{

    private readonly BookishDBContext _context;
    public BookRepo(BookishDBContext context) 
    {
        _context = context;
    }

    public List<BookModel> GetAllBooks()
    {
        return _context.Books
            .Include(b => b.Authors)
            .ToList();
    }

    public BookModel GetBookByIsbn(string isbn)
    {
        return _context.Books
            .Include(b => b.Authors)
            .Where(b => b.Isbn == isbn)
            .Single();
    }
}