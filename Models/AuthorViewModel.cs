namespace Bookish.Models;

public class AuthorViewModel
{
    public int AuthorId { get; }
    public string Name { get; }
    public int? BirthYear { get; set;}
    public string? PhotoUrl { get; set;}
    public string? Bio { get;  set;}

    public AuthorViewModel(int authorId, string name){
        AuthorId = authorId;
        Name = name;
    }
}
