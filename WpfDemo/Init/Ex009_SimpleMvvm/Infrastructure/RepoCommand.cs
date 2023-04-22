using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex009_SimpleMvvm.Infrastructure
{
  public class RepoCommand : ICommand
  {
    readonly Action<object> execute;
    readonly Predicate<object> canExecute;

    public RepoCommand(Action<object> execute)
        : this(execute, null) { }

    public RepoCommand(Action<object> Execute, Predicate<object> CanExecute = null)
    {
      if (Execute == null) throw new ArgumentNullException("null object");
      execute = Execute;
      canExecute = CanExecute;
    }

    public bool CanExecute(object parameter)=>
      canExecute == null ? true : canExecute.Invoke(parameter);

    public event EventHandler CanExecuteChanged
    {
      add=> CommandManager.RequerySuggested += value;
      remove=> CommandManager.RequerySuggested -= value;
    }

    public void Execute(object parameter) => 
      execute.Invoke(parameter);
  }
}
