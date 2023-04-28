using Model;

namespace Generator
{
  public class ModelGenerator
  {
    private static ModelGenerator instance;
    public static ModelGenerator Instance => instance ??= new();

    private string NewGuid(int count = 5)
    {
      return Guid.NewGuid().ToString().Substring(0, count);
    }
    public Worker GetWorker() =>
        new Worker
        {
          Id = $"{NewGuid(20)}",
          FirstName = $"{NewGuid()}",
          LastName = $"{NewGuid()}",
          Age = Random.Shared.Next(18, 80),
          Login = $"{NewGuid()}",
          Department = $"#{NewGuid()}",
          Salary = Random.Shared.Next(30, 100) * 1000,
          Address = $"{NewGuid(15)}",
        };
  }
}