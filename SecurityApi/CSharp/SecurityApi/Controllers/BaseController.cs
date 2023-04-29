using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistance;

[Authorize("TokenSecurityPolicy")]
[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{
  protected readonly IConfiguration configuration;
  protected readonly IRepository repository;

  public BaseController(IConfiguration configuration, IRepository repository)
  {
    this.configuration = configuration;
    this.repository = repository;
  }
}