using Ex006_INotifyPropertyChanged.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex006_INotifyPropertyChanged
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      var model = Organization.Instance;
     
      gridView.DataContext = model;
      btnAppendDepartment.Click += delegate { model.AppendDepartment(); };
      btnEditDepartment.Click += delegate { model.EditDepartment(lbDepartment.SelectedIndex); };
      //btnEditDepartment.Click += delegate {
      //  MessageBox.Show($"{lbDepartment.SelectedIndex} {lbDepartment.SelectedItems.Count}");
      //};
    }
  }
}