using Ex009_SimpleMvvm.Infrastructure;
using Ex009_SimpleMvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex009_SimpleMvvm.ViewModel
{
  public class MainVM : AbstractVM
  {
    Worker currentWorker;
    public Worker CurrentWorker
    {
      get
      {
        if (currentWorker == null)
          currentWorker = new Worker("Full Name", "");
        return currentWorker;
      }
      set
      {
        currentWorker = value;
        OnPropertyChanged(nameof(this.CurrentWorker));
      }
    }
    ObservableCollection<Worker> workers;
    public ObservableCollection<Worker> Workers
    {
      get
      {
        if (workers == null)
          workers = WorkersRepository.AllWorkers;
        return workers;
      }
    }
    RepoCommand addWorkerCommand;
    public ICommand AddWorker
    {
      get
      {
        if (addWorkerCommand == null)
          addWorkerCommand = new RepoCommand(ExecuteAddClientCommand, CanExecuteAddClientCommand);
        return addWorkerCommand;
      }
    }
    private void ExecuteAddClientCommand(object parameter)
    {
      Workers.Add(currentWorker);
      CurrentWorker = null;
    }
    private bool CanExecuteAddClientCommand(object parameter)
    {
      if (string.IsNullOrEmpty(CurrentWorker.FullName) ||
          string.IsNullOrEmpty(CurrentWorker.DepartmentName))
        return false;
      return true;
    }
    protected override void OnDispose() => this.Workers.Clear();
  }
}