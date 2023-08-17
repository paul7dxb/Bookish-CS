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

    public BookController(IBookRepo bookRepo){
        _bookRepo = bookRepo;
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
        BookModel book = _bookRepo.GetBookByIsbn(isbn);
        return View(new BookViewModel(book));
    }
}
