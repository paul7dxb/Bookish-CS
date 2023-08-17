using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Repositories;
using Bookish.Models.Database;

namespace Bookish.Controllers;

[Route("users")]
public class UserController : Controller
{
    private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo){
            _userRepo = userRepo;
        }

    [HttpGet("")]
    public IActionResult Index()
    {
        List<UserModel> users = _userRepo.GetAllUsers();
        return View(users.Select(user => new UserViewModel(user)).ToList());
    }

    [HttpGet("{UserId}")]
    public IActionResult User([FromRoute] int userId)
    {
        UserModel user = _userRepo.GetUserById(userId);
        return View(new UserViewModel(user));
    }
}
