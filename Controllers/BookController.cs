using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Repositories;
using Bookish.Models.Database;

namespace Bookish.Controllers;

[Route("books")]
public class BookController : Controller
{
    private readonly IBookRepo _bookRepo;
    private readonly IBookCopyRepo _bookCopyRepo;

    public BookController(IBookRepo bookRepo, IBookCopyRepo bookCopyRepo ){
        _bookRepo = bookRepo;
        _bookCopyRepo = bookCopyRepo;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        List<BookModel> books = _bookRepo.GetAllBooks();
        return View(books.Select(book => new BookViewModel(book)).ToList());
    }

    [HttpGet("{isbn}")]
    public IActionResult Book([FromRoute] string isbn)
    {
        BookModel bookModel = _bookRepo.GetBookByIsbn(isbn);
        int copies = _bookCopyRepo.GetAllCopies(isbn).Count;
        var book = new BookViewModel(bookModel, copies);
        return View(book);
    }
}
