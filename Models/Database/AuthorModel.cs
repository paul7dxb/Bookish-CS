namespace Bookish.Models.Database;

public class AuthorModel
{
    public int Id { get; set; }
    public string Name { get; set;}
    public int? BirthYear { get; set;}
    public string? PhotoUrl { get; set;}
    public string? Bio { get;  set;}

    public List<BookModel> Books { get; set; }

}
