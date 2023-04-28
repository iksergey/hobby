using DemoMapper;
using AutoMapper;
using API;
using AppConfig;
using Generator;
using Extensions;
using Model;

IMapper mapper = new MapperConfiguration(cfg =>
{
  cfg.AddProfile<AutoMapperProfile>();
})
.CreateMapper();

Repository repo = new(ModelGenerator.Instance, mapper, count: 1);
Console.WriteLine("repo");
repo.Print();

WorkerController wc = new(repo, mapper);

Worker userData = ModelGenerator.Instance.GetWorker();
Console.WriteLine("userData"); userData.Print();

WorkerDto apiWorker = wc.Get(0);

repo.Update(apiWorker.Id, userData);

Console.WriteLine("repo");
repo.Print();
