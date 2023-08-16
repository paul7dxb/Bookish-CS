namespace Bookish.Models;

public class UserViewModel
{
    public int Id { get; }
    public string Name { get; }
    public string? Email { get; set;}
    public DateTime? DateSignedUp { get; set;}

    // public List<>

    public UserViewModel(int id, string name){
        Id = id;
        Name = name;
    }
}
