using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories;

public interface IBookCopyRepo
{
    public List<BookCopyModel> GetAllCopies(string isbn);

}

public class BookCopyRepo : IBookCopyRepo
{

    private readonly BookishDBContext _context;
    public BookCopyRepo(BookishDBContext context) 
    {
        _context = context;
    }

    public List<BookCopyModel> GetAllCopies(string isbn)
    {
        return _context.Copies.Where(c => c.Book.Isbn == isbn).ToList();
    }



    // public void AddBook(BookViewModel newBook, int noOfCopies)
    // {
    //     _context.Books;
    // }

}