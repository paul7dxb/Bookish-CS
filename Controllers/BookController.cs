using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

[Route("books")]
public class BookController : Controller
{

    private List<BookViewModel> Books = new List<BookViewModel>{
        new BookViewModel("0261103253", "The Lord Of The Rings","J.R.R. Tolkien"){
            CoverPhotoUrl= "https://m.media-amazon.com/images/P/0261103253.01._SCLZZZZZZZ_SX500_.jpg",
            Blurb = "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.",
            Genre = "Fantasy",
            YearPublished = 1955,
            },
            new BookViewModel("9780001831803", "The Lion, the Witch and the Wardrobe","C.S. Lewis"){
            CoverPhotoUrl= "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
            Genre = "Fantasy",
            YearPublished = 1950,
            },
        new BookViewModel("0261103253", "The Lord Of The Rings","J.R.R. Tolkien"){
            CoverPhotoUrl= "https://m.media-amazon.com/images/P/0261103253.01._SCLZZZZZZZ_SX500_.jpg",
            Blurb = "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.",
            Genre = "Fantasy",
            YearPublished = 1955,
            },
            new BookViewModel("9780001831803", "The Lion, the Witch and the Wardrobe","C.S. Lewis"){
            CoverPhotoUrl= "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
            Genre = "Fantasy",
            YearPublished = 1950,
            },
        new BookViewModel("0261103253", "The Lord Of The Rings","J.R.R. Tolkien"){
            CoverPhotoUrl= "https://m.media-amazon.com/images/P/0261103253.01._SCLZZZZZZZ_SX500_.jpg",
            Blurb = "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.",
            Genre = "Fantasy",
            YearPublished = 1955,
            },
            new BookViewModel("9780001831803", "The Lion, the Witch and the Wardrobe","C.S. Lewis"){
            CoverPhotoUrl= "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
            Genre = "Fantasy",
            YearPublished = 1950,
            },
        new BookViewModel("0261103253", "The Lord Of The Rings","J.R.R. Tolkien"){
            CoverPhotoUrl= "https://m.media-amazon.com/images/P/0261103253.01._SCLZZZZZZZ_SX500_.jpg",
            Blurb = "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.",
            Genre = "Fantasy",
            YearPublished = 1955,
            },
            new BookViewModel("9780001831803", "The Lion, the Witch and the Wardrobe","C.S. Lewis"){
            CoverPhotoUrl= "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
            Genre = "Fantasy",
            YearPublished = 1950,
            },
        new BookViewModel("0261103253", "The Lord Of The Rings","J.R.R. Tolkien"){
            CoverPhotoUrl= "https://m.media-amazon.com/images/P/0261103253.01._SCLZZZZZZZ_SX500_.jpg",
            Blurb = "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.",
            Genre = "Fantasy",
            YearPublished = 1955,
            },
            new BookViewModel("9780001831803", "The Lion, the Witch and the Wardrobe","C.S. Lewis"){
            CoverPhotoUrl= "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
            Genre = "Fantasy",
            YearPublished = 1950,
            },
        new BookViewModel("0261103253", "The Lord Of The Rings","J.R.R. Tolkien"){
            CoverPhotoUrl= "https://m.media-amazon.com/images/P/0261103253.01._SCLZZZZZZZ_SX500_.jpg",
            Blurb = "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.",
            Genre = "Fantasy",
            YearPublished = 1955,
            },
            new BookViewModel("9780001831803", "The Lion, the Witch and the Wardrobe","C.S. Lewis"){
            CoverPhotoUrl= "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
            Genre = "Fantasy",
            YearPublished = 1950,
            },
    };

    [HttpGet("")]
    public IActionResult Index()
    {
        return View(Books);
    }

    [HttpGet("{isbn}")]
    public IActionResult Book([FromRoute] string isbn)
    {
        BookViewModel book = null;
        var bookIndex = Books.FindIndex(book=> book.Isbn == isbn);
        if(bookIndex >= 0)
        {
            book = Books[bookIndex];
        }
        else
        {
            return NotFound();
        };
        return View(book);
    }
}
