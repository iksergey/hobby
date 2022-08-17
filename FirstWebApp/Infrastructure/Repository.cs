class Repository
{
  public class Student
  {
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
  }

  static public Student[] GetStudents(int count = 30)
  {
    var data = new Student[count];
    for (int i = 1; i <= count; i++)
    {
      data[i - 1] = new Student
      {
        Id = i,
        FullName = $"Имя {i}  Фамилия {i}",
        Age = Random.Shared.Next(14, 25)
      };
    }
    return data;
  }
}