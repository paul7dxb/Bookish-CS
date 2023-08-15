namespace Bookish.Models;

public class BookViewModel
{
    public string Isbn { get; }
    public string Title { get; }
    public string Author { get; }
    public string? CoverPhotoUrl { get;  set;}
    public string? Blurb { get; set; }
    public string? Genre { get; set;}
    public int? YearPublished { get; set; }

    public BookViewModel(string isbn, string title, string author){
        Isbn = isbn;
        Title = title;
        Author = author;
    }
}
