using API;
using Extensions;
using Generator;
using Model;
using NoMapper;

Repository repo = new(ModelGenerator.Instance, count: 1);
Console.WriteLine("repo");
repo.Print();

WorkerController wc = new(repo);
wc.Print();

Worker userData = ModelGenerator.Instance.GetWorker();
Console.WriteLine("userData"); userData.Print();

WorkerDto apiWorker = wc.Get(0);

repo.Update(apiWorker.Id, userData);

Console.WriteLine("repo");
repo.Print();