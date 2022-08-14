public static class Extensions
{
  // разбора строки
  public static int[] NumbFrom(this string str)
  {
    return Array
     .ConvertAll(
      str.Split(' '),
      int.Parse
     );
  }

  // метод подготовки для вывода
  public static string Prepare(this int[] numbers)
  {
    return String.Join(' ', numbers);
  }

  // какая-то обработки чисел
  public static int[] Processing(this int[] numbers)
  {
    return numbers
      // пусть будет возведение 
      .Select(el => 2 * el)
      .ToArray();
  }
}