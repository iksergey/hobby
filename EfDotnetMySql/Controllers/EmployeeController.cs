using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
  private readonly DataContext context;
  public EmployeeController(DataContext context)
  {
    this.context = context;
  }

  [HttpGet]
  public async Task<ActionResult<Employee>> Get(int id)
  {
    return await context.Employees
                  .Where(item => item.Id == id)
                  .FirstOrDefaultAsync();
  }

  [HttpPost]
  public async Task<ActionResult<Employee>> Create(Employee worker)
  {
    context.Employees.Add(worker);
    await context.SaveChangesAsync();
    return await Get(worker.Id);
  }
}