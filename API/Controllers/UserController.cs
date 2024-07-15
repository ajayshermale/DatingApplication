using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API;

[ApiController]
[Route("Api/{Controller}")]
public class UserController(DataContext context) : Controller
{
    
[HttpGet]

public async Task<ActionResult<IEnumerable<AddUser>>> GetUsers()
{
    var user = await context.Users.ToListAsync();
    return user;

}

[HttpGet("{Id:int}")]
public async Task<ActionResult<AddUser>> Getuser(int Id)
{
    var user = await context.Users.FindAsync(Id);

    if(user == null) return NotFound();

    return user;
}

}
