using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    // Use DI to inject the SocialAppContext
    private readonly SocialAppContext _sessionContext;
    public UsersController(SocialAppContext context)
    {
        _sessionContext = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _sessionContext.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        var user = await _sessionContext.Users.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        return user;
    }
}
