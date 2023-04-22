using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009_SimpleMvvm.Model
{
  public static class WorkersRepository
  {
    private static ObservableCollection<Worker>? workers;
    public static ObservableCollection<Worker> AllWorkers
    {
      get
      {
        if (workers == null)
          workers = Init();
        return workers;
      }
    }
    private static ObservableCollection<Worker> Init()
    {
      ObservableCollection<Worker> clients = new ObservableCollection<Worker>();
      clients.Add(new Worker("Имя 1 Фамилия 1", "Отдел 1"));
      clients.Add(new Worker("Имя 2 Фамилия 2", "Отдел 2"));
      clients.Add(new Worker("Имя 3 Фамилия 3", "Отдел 3"));
      return clients;
    }
    public static void AppendWorker(string fullName, string departmentName)
    {
      if (String.IsNullOrEmpty(fullName) || String.IsNullOrEmpty(departmentName))
      {
        return;
      }
      else
      {
        Worker worker = new Worker(fullName, departmentName);
        workers?.Add(worker);
      }
    }
  }
}
