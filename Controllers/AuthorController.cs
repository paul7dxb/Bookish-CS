using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Repositories;
using Bookish.Models.Database;

namespace Bookish.Controllers;

[Route("authors")]
public class AuthorController : Controller
{

    private readonly AuthorRepo _authorRepo;

    public AuthorController(AuthorRepo authorRepo){
        _authorRepo = authorRepo;
    }

    private List<AuthorViewModel> Authors = new List<AuthorViewModel>
    {
        new AuthorViewModel(1, "J.R.R. Tolkien")
        {
            BirthYear = 1892,
            PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/J._R._R._Tolkien%2C_ca._1925.jpg/220px-J._R._R._Tolkien%2C_ca._1925.jpg",
            Bio = "John Ronald Reuel Tolkien CBE FRSL (/ˈruːl ˈtɒlkiːn/, ROOL TOL-keen; 3 January 1892 – 2 September 1973) was an English writer and philologist. He was the author of the high fantasy works The Hobbit and The Lord of the Rings."         
        },
        new AuthorViewModel(2, "C.S. Lewis")
        {
            BirthYear = 1898,
            PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1e/C.s.lewis3.JPG/220px-C.s.lewis3.JPG",
            Bio = "Clive Staples Lewis, FBA (29 November 1898 – 22 November 1963) was a British writer, literary scholar, and Anglican lay theologian. He held academic positions in English literature at both Oxford University (Magdalen College, 1925–1954) and Cambridge University (Magdalene College, 1954–1963). He is best known as the author of The Chronicles of Narnia, but he is also noted for his other works of fiction, such as The Screwtape Letters and The Space Trilogy, and for his non-fiction Christian apologetics, including Mere Christianity, Miracles, and The Problem of Pain. "
        },
    };


    [HttpGet("")]
    public IActionResult Index()
    {
        List<AuthorModel> authors = _authorRepo.GetAllAuthors();

        return View(authors.Select(author => new AuthorViewModel(author)));
    }

    [HttpGet("{AuthorId}")]
    public IActionResult Author([FromRoute] int authorId)
    {
        AuthorViewModel author = null;
        var authIndex = Authors.FindIndex(author=> author.Id == authorId);
        if(authIndex >= 0)
        {
            author = Authors[authIndex];
        }
        else
        {
            return NotFound();
        };
        
        return View(author);
    }
}
