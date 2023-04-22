using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static System.Convert;

namespace Ex007_Converter.Converters
{
  public class DayWeekConverter : IValueConverter
  {
    public object Convert(object value, Type targetType,
                          object parameter, CultureInfo culture)
    {
      var dayNumber = ToInt32(value);
      return dayNumber switch
      {
        1 => "Monday",
        2 => "Tuesday",
        3 => "Wednesday",
        4 => "Thursday",
        5 => "Friday",
        6 => "Saturday",
        7 => "Sunday",
        _ => "ERROR"
      };
    }


    public object ConvertBack(object value, Type targetType,
        object parameter, CultureInfo culture)
    {
      var day = value.ToString();
      return day switch
      {
        "Monday" => 1,
        "Tuesday" => 2,
        "Wednesday" => 3,
        "Thursday" => 4,
        "Friday" => 5,
        "Saturday" => 6,
        "Sunday" => 7,
        _ => -1
      };
    }
  }
}