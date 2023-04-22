using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009_SimpleMvvm.Model
{
  public class Worker
  {
    public string FullName { get; set; }
    public string DepartmentName { get; set; }

    public Worker() { }
    public Worker(string fullName, string departmentName)
    {
      FullName = fullName;
      DepartmentName = departmentName;
    }
    public override string ToString()
    {
      return $"{FullName} {DepartmentName}";
    }
  }
}