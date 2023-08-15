namespace Bookish.Models;

public class BookViewModel
{
    public string Isbn { get; }
    public string Title { get; }
    public string? CoverPhotoUrl { get;  set;}
    public string? Blurb { get; set; }
    public string? Genre { get; set;}
    public int? YearPublished { get; set; }

    public BookViewModel(string isbn, string title){
        Isbn = isbn;
        Title = title;
    }
}
