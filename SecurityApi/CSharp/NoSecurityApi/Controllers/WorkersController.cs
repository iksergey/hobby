using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Persistance;

namespace CSharp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class WorkersController : ControllerBase
  {
    private IRepository repository;
    public WorkersController(IRepository repository)
    {
      this.repository = repository;
    }

    [HttpGet("get")]
    public IEnumerable<Worker> Get()
      => repository.GetAll();
    [HttpGet("get/{id}")]
    public ActionResult<Worker> GetById(string id)
      => Ok(repository.Get(id));

    [HttpDelete("remove/{id}")]
    public IActionResult Remove(string id)
       => Ok(repository.Remove(id));
  }
}