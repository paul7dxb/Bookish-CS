namespace Bookish.Models.Database;

public class UserModel
{
    public int Id { get; set;}
    public string Name { get; set;}
    public string? Email { get; set;}
    public DateTime? DateSignedUp { get; set;}

}
