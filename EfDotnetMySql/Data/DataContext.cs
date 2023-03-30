using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
  public DbSet<Employee> Employees { get; set; }
  public DbSet<Department> Departments { get; set; }

  public DataContext(DbContextOptions<DataContext> op)
  : base(op)
  { }
}