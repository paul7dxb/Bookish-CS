using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

[Route("users")]
public class UserController : Controller
{
    private List<UserViewModel> Users = new List<UserViewModel>
    {
        new UserViewModel(1, "Paul")
        {
            Email = "paul@email.com",
            DateSignedUp = DateTime.Now ,
        },
        new UserViewModel(2, "Bill")
        {
            Email = "bill@email.com",
            DateSignedUp = DateTime.Now ,
        },
    };

    [HttpGet("")]
    public IActionResult Index()
    {
        return View(Users);
    }

    [HttpGet("{UserId}")]
    public IActionResult User([FromRoute] int userId)
    {
        UserViewModel user = null;
        var userIndex = Users.FindIndex(user=> user.Id == userId);
        if(userIndex >= 0)
        {
            user = Users[userIndex];
        }
        else
        {
            return NotFound();
        };
        
        return View(user);
    }
}
