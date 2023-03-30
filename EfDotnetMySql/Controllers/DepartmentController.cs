using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class DepartmentController : ControllerBase
{
  private readonly DataContext context;
  public DepartmentController(DataContext context)
  {
    this.context = context;
  }

  [HttpGet]
  public async Task<ActionResult<Department>> Get(int id)
  {
    return await
      context.Departments
             .Where(e => e.Id == id)
             .FirstOrDefaultAsync();
  }

  [HttpPost]
  public async Task<ActionResult<Department>> Create(Department department)
  {
    context.Departments.Add(department);
    await context.SaveChangesAsync();
    return await Get(department.Id);
  }
}