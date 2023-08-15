namespace Bookish.Models;

public class AuthorViewModel
{
    public string Name { get; }
    public int? BirthYear { get; set;}
    public string? PhotoUrl { get; set;}
    public string? Bio { get;  set;}

    public AuthorViewModel(string name){
        Name = name;
    }
}
