using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet(Name = "login")]
    public IActionResult Login(string email, string password){

        return Ok(new { 
            date = DateTime.Now,
            info = "Login successful" 
        });
    }
}