using Ex008_SimpleBook.Repository;
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

namespace Ex008_SimpleBook
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      Loaded += delegate { lbWorkers.ItemsSource = WorkersRepository.AllWorkers; };
      btnAppendWorker.Click += delegate
      {
        WorkersRepository.
        AppendWorker(tbFullName.Text, tbDepartment.Text);
      };
    }
  }
}
