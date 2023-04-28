using System.Text;

namespace Extensions
{
  public static class Printer
  {
    public static string Print<T>(this T model, bool viewInConsole = true)
    where T : class
    {
      var props = typeof(T).GetProperties();
      StringBuilder sb = new();
      foreach (var prop in props)
        sb.Append($"{prop.Name}: {prop.GetValue(model)}\n");

      if (viewInConsole) Console.WriteLine(sb);
      return sb.ToString();
    }
  }
}