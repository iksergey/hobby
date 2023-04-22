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

namespace Ex005_DataBinding
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      //Binding binding = new Binding
      //{
      //  ElementName = nameof(tbText),
      //  Path = new PropertyPath(nameof(tbText.Text)),
      //  Mode = BindingMode.TwoWay,
      //  UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
      //};

      //tbMirror.SetBinding(TextBlock.TextProperty, binding);
    }
  }
}
