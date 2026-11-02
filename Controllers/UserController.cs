using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    // http://localhost:5006/
    [HttpGet("/")]
    public IActionResult Index(){
        return Ok(new { 
            date = DateTime.Now,
            info = "Alexey Suzdalenko"
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