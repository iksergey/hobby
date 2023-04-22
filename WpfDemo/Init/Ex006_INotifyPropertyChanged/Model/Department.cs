using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006_INotifyPropertyChanged.Model
{
  public class Department : INotifyPropertyChanged
  {
    public Department(string name)
    {
      this.name = name;
    }
    string name;
    public string Name
    {
      get => this.name;
      set
      {
        this.name = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}