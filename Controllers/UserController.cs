using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly DeCaDbContext _context;
     public UserController(DeCaDbContext context)
    {
        _context = context;
    }

    // http://localhost:5006/
    [HttpGet("/")]
    public async Task<IActionResult> Index(){

        var users = await _context.Users
            .AsNoTracking()
            .Where(u => u.Id > 0)
            .OrderBy(u => u.Id)
            .Select(u => new {u.Id, u.Email, u.CreatedAt, u.LastLoginAt })
            .ToListAsync();
        
        return Ok(new { 
            date = DateTime.Now,
            info = "Alexey Suzdalenko",
            users = users
        });
    }

    // http://localhost:5006/api/user/login?email=alexey@gmail.com&password=123456
    [HttpGet("login")]
    public IActionResult Login(string email, string password){

        return Ok(new { 
            date = DateTime.Now,
            info = "Login successful",
            email = email,
            password = password
        });
    }
}