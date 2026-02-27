using Microsoft.AspNetCore.Mvc;
using TarefasAPI.Services;
using BCrypt.Net;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwt;

    public AuthController(JwtService jwt)
    {
        _jwt = jwt;
    }

    [HttpPost("login")]
    public IActionResult Login(string username, string password)
    {
        
        var senhaHash = BCrypt.Net.BCrypt.HashPassword("123456");

        if (username == "admin" &&
            BCrypt.Net.BCrypt.Verify(password, senhaHash))
        {
            var token = _jwt.GerarToken(username);
            return Ok(new { token });
        }

        return Unauthorized();
    }
}