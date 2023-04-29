using Microsoft.AspNetCore.Mvc;
using Model;
using Persistance;

namespace Controllers
{
  public class WorkersController : BaseController
  {
    public WorkersController(IConfiguration configuration, IRepository repository)
      : base(configuration, repository)
    {
    }

    [HttpGet("get")]
    public IEnumerable<Worker> Get()
      => base.repository.GetAll();

    [HttpGet("get/{id}")]
    public ActionResult<Worker> GetById(string id)
      => Ok(repository.Get(id));

    [HttpDelete("remove/{id}")]
    public IActionResult Remove(string id)
       => Ok(repository.Remove(id));
  }
}