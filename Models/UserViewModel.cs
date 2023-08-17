using Bookish.Models.Database;

namespace Bookish.Models;

public class UserViewModel
{
    public int? Id { get; }
    public string? Name { get; }
    public string? Email { get; set;}
    public DateTime? DateSignedUp { get; set;}

    // public UserViewModel(int id, string name){
    //     Id = id;
    //     Name = name;
    // }

    public UserViewModel(UserModel userModel)
    {
        Id = userModel.Id;
        Name = userModel.Name;
        Email = userModel.Email;
        DateSignedUp = userModel.DateSignedUp;
    }
}
