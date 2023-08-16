using Microsoft.EntityFrameworkCore;

namespace Bookish.Models.Database;

[PrimaryKey("Isbn")]
public class BookModel
{
    public string Isbn { get; set; }

    public string Title { get; set; }
    public string? CoverPhotoUrl { get;  set;}
    public string? Blurb { get; set; }
    public string? Genre { get; set;}
    public int? YearPublished { get; set; }

    public List<AuthorModel> Authors { get; set; }

}
