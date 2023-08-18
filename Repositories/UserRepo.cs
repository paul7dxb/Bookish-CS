using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;
namespace Bookish.Repositories;


public interface IUserRepo
{
    public List<UserModel> GetAllUsers();
    public UserModel GetUserById(int id);

    public HttpResponseMessage AddUser(string name, string email);
    //public void EditUser(string name, string email);
}

public class UserRepo : IUserRepo
{
    private readonly BookishDBContext _context;
    public UserRepo(BookishDBContext context) 
    {
        _context = context;
    }

    public List<UserModel> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    public UserModel GetUserById(int id)
    {
        return _context.Users
            .Where(u => u.Id == id)
            .Single();
    }

    public HttpResponseMessage AddUser(string name, string email){
        
        var userData = new UserModel(){
            Id = null,
            DateSignedUp = DateTime.UtcNow ,
            Name = name,
            Email = email
        };

        try{
            _context.Users.Add(userData);

            _context.SaveChanges(); 
        }catch(Exception e)
        {
            Console.WriteLine(e.ToString());
            return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
        }    

        return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        
    }

}