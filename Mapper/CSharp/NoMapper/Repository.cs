using Extensions;
using Generator;
using Model;

namespace NoMapper
{
  public class Repository
  {
    List<Worker> db;
    public Repository(ModelGenerator mg, int count = 3)
    {
      db = new();
      for (int i = 0; i < count; i++)
      {
        db.Add(mg.GetWorker());
      }
    }

    public void Print()
    {
      foreach (var item in db) item.Print();
    }

    public Worker Get(int index) => db[index];

    public void Update(string id, Worker item)
    {
      if (item == null) return;
      Worker w = db.Find(e => e.Id == id);
      if (w != null)
      {
        if (item.FirstName != null)
          w.FirstName = item.FirstName;
        if (item.FirstName != null)
          w.LastName = item.LastName;
        w.Age = item.Age;
        if (item.FirstName != null)
          w.Login = item.Login;
        if (item.FirstName != null)
          w.Department = item.Department;
        w.Salary = item.Salary;
        if (item.FirstName != null)
          w.Address = item.Address;
      }
    }
  }
}