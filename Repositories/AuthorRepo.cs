using Bookish.Models.Database;

namespace Bookish.Repositories;

public class AuthorRepo
{
    public List<AuthorModel> GetAllAuthors()
    {
        using (var context = new BookishDBContext()) 
        {
            return context.Authors.ToList();
        }
    }
}