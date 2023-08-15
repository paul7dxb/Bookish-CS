using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

[Route("books")]
public class BookController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("book")]
    public IActionResult Book()
    {
        var book = new BookViewModel("8127398173212", "The Lord Of The Rings");
        return View(book);
    }
}
