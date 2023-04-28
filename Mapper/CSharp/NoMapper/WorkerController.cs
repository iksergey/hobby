using NoMapper;
using Model;
using Infrastructure;

namespace API
{
  public class WorkerController
  {
    Repository repo;
    public WorkerController(Repository repo)
    { this.repo = repo; }

    public WorkerDto Get(int index)
    { return repo.Get(index).ToDto(); }

    public int Update(string id, Worker data)
    {
      try { repo.Update(id, data); return 201; }
      catch { return 400; }
    }
  }
}