using Generator;
using Model;

namespace Persistance
{
  public class Repository : IRepository
  {
    private readonly IModelGenerator mg;
    private List<Worker> db;

    public Repository(IModelGenerator mg)
    {
      this.mg = mg;
      db = new();
      Init();
    }

    private void Init()
    {
      for (int i = 0; i < 3; i++)
      {
        db.Add(mg.GetWorker());
      }
    }

    public Worker Get(string id)
      => db.Find(item => item.Id == id);
    public Worker[] GetAll()
      => db.ToArray();
    public bool Remove(string id)
      => db.RemoveAll(e => e.Id == id) != 0;
  }
}