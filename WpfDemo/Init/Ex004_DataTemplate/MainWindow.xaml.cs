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
using Ex004_DataTemplate.Models;

namespace Ex004_DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      var model = AsyncModel.Instance;
      lbItems.ItemsSource = model.Numbers;
      btnAddItems.Click += delegate { model.AddItems(); };
      btnSelectionSortItems.Click += delegate { model.SelectionSort(); };
      btnQuickSortItems.Click += delegate { model.QuickSort(); };
      btnShuffleItems.Click += delegate { model.ShuffleItems(); };
      btnClearItems.Click += delegate { model.Clear(); };
    }
  }
}
