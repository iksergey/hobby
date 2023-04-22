using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006_INotifyPropertyChanged.Model
{
  public class Organization : INotifyPropertyChanged
  {
    public static readonly Organization Instance = new Organization();
    private bool accredited;
    public event PropertyChangedEventHandler PropertyChanged;
    public bool Accredited
    {
      get => this.accredited;
      set
      {
        this.accredited = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Accredited)));
      }
    }
    public ObservableCollection<Department> Departments { get; set; }
    private Organization()
    {
      Departments = new();
      for (int i = 0; i < Random.Shared.Next(3, 7); i++)
      {
        AppendDepartment();
      }
      this.Accredited = true;
    }

    public void AppendDepartment(string departmentName = "")
    {
      string depName = String.IsNullOrEmpty(departmentName)
        ? $"Departament #{Guid.NewGuid().ToString().Substring(0, 5)}"
        : departmentName;
      Departments.Add(new Department(depName));
    }

    public void EditDepartment(int id)
    {
      if (id < 0) return;
      string depName = Departments[id].Name;
      Departments[id].Name = $"New {depName}";
    }
  }
}