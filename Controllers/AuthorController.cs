using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Repositories;
using Bookish.Models.Database;

namespace Bookish.Controllers;

[Route("authors")]
public class AuthorController : Controller
{

    private readonly IAuthorRepo _authorRepo;

    public AuthorController(IAuthorRepo authorRepo){
        _authorRepo = authorRepo;
    }


    [HttpGet("")]
    public IActionResult Index()
    {
        List<AuthorModel> authors = _authorRepo.GetAllAuthors();
        return View(authors.Select(author => new AuthorViewModel(author)).ToList());
    }

    [HttpGet("{AuthorId}")]
    public IActionResult Author([FromRoute] int authorId)
    {

        AuthorModel author = _authorRepo.GetAuthorById(authorId);
              
        return View(new AuthorViewModel(author));
    }
}
