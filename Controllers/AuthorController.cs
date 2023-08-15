using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

[Route("authors")]
public class AuthorController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        var  authorList = new List<AuthorViewModel>{
            new AuthorViewModel("J.R.R Tolkien"){
                
            },
            new AuthorViewModel("J.R.R Tolkien"){
            },

        };
        return View(authorList);
    }

    [HttpGet("author")]
    public IActionResult Author()
    {
        var author = new AuthorViewModel("J.R.R Tolkien"){
            
        };
        return View(author);
    }
}
