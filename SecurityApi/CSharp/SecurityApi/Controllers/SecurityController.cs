using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Persistance;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

public class SecurityController : BaseController
{
  public SecurityController(IConfiguration configuration, IRepository repository)
    : base(configuration, repository)
  {
  }

  [AllowAnonymous]
  [HttpPost("token")]
  public IActionResult GenerateToken()
  {
    var claims = new[]
    {
        new Claim(JwtRegisteredClaimNames.Sub, "username"),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new Claim(ClaimTypes.Role, "User")
    };

    var key = new SymmetricSecurityKey(
        Encoding.UTF8.GetBytes(
          configuration["SecurityToken"]
          )
      );
    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

    var token = new JwtSecurityToken(
        issuer: "admin",
        audience: "valid",
        claims: claims,
        expires: DateTime.Now.AddMinutes(2),
        signingCredentials: creds);

    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
  }
}