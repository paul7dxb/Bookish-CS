namespace Bookish.Models;

public class AuthorViewModel
{
    public int Id { get; }
    public string Name { get; }
    public int? BirthYear { get; set;}
    public string? PhotoUrl { get; set;}
    public string? Bio { get;  set;}

    public AuthorViewModel(int id, string name){
        Id = id;
        Name = name;
    }
}
