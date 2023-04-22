using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009_SimpleMvvm.ViewModel
{
  public abstract class AbstractVM : INotifyPropertyChanged, IDisposable
  {
    protected AbstractVM() { }
    public event PropertyChangedEventHandler PropertyChanged;
    public virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler handler = this.PropertyChanged;
      handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public void Dispose() => this.OnDispose();
    protected virtual void OnDispose() { }
  }
}
