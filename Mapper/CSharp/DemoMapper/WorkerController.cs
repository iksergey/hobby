using AutoMapper;
using DemoMapper;
using Model;

namespace API
{
  public class WorkerController
  {
    Repository repo;
    IMapper mapper;
    public WorkerController(Repository repo, IMapper mapper)
    {
      this.repo = repo;
      this.mapper = mapper;
    }

    public WorkerDto Get(int index)
    { return mapper.Map<WorkerDto>(repo.Get(index)); }

    public int Update(string id, Worker data)
    {
      try { repo.Update(id, data); return 201; }
      catch { return 400; }
    }
  }
}