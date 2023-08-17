using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;
namespace Bookish.Repositories;


public interface IUserRepo
{
    public List<UserModel> GetAllUsers();
    public UserModel GetUserById(int id);

    public void AddUser(string name, string email);
    public void EditUser(string name, string email);
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

    public void AddUser(string name, string email){
        // _context.Users.Add()
    }
    public void AddUser(string name, string email){
        // _context.Users
    }
}