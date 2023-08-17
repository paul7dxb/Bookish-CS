using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;
namespace Bookish.Repositories;


public interface IAuthorRepo
{
    public List<AuthorModel> GetAllAuthors();
    public AuthorModel GetAuthorById(int id);
}

public class AuthorRepo : IAuthorRepo
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

    public AuthorModel GetAuthorById(int id)
    {
        return _context.Authors
            .Include(a => a.Books)
            .Where(a => a.Id == id)
            .Single();
    }
}