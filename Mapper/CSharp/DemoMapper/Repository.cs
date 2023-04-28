using System.Text;
using AutoMapper;
using Extensions;
using Generator;
using Model;

namespace DemoMapper
{
  public class Repository
  {
    List<Worker> db;
    IMapper mapper;
    public Repository(ModelGenerator mg, IMapper mapper, int count = 3)
    {
      this.mapper = mapper;
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
      Worker w = db.Find(e => e.Id == id);
      mapper.Map(item, w);
    }
  }
}