using Model;

namespace Infrastructure
{
  public static class Converter
  {
    public static WorkerDto ToDto(this Worker from)
    {
      return new WorkerDto
      {
        Id = from.Id,
        FirstName = from.FirstName,
        LastName = $"{from.LastName?[0]}.",
        Age = from.Age
      };
    }
  }
}