namespace Bookish.Models;

using Bookish.Models.Database;

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
    public AuthorViewModel(AuthorModel authorModel){
        Id = authorModel.Id;
        Name = authorModel.Name;
        BirthYear = authorModel.BirthYear;
        PhotoUrl = authorModel.PhotoUrl;
        Bio = authorModel.Bio;
    }
}
