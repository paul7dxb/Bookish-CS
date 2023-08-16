using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;
namespace Bookish.Repositories;


public class AuthorRepo
{
    private readonly BookishDBContext _context;
    public AuthorRepo(BookishDBContext context) 
    {
        _context = context;
    }

    public List<AuthorModel> GetAllAuthors()
    {
        return _context.Authors
            .Include(b => b.Books)
            .ToList();
    }
}