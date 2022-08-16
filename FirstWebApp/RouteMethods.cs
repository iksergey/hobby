
public static class RouteMethods
{
  // --/about
  /// <summary>
  /// Информация о проекте.
  /// </summary>
  /// <returns>Текст, который нужно осмыслить</returns>
  public static string About()
  {
    return "Проект, в котором нашлось место для статики!";
  }
  /// <summary>
  /// Приветствие пользователя
  /// </summary>
  /// <param name="name">Имя пользователя</param>
  /// <returns>Случайное приветствие</returns>
  public static string Hi(string name)
  {
    string[] greetingOptions = {
        "Привет",
        "Здравствуйте",
        "Доброго времени суток"
      };
    int ci = Random.Shared.Next(greetingOptions.Length);
    return $"{greetingOptions[ci]}, {name}!";
  }

  /// <summary>
  /// Сумма чисел
  /// </summary>
  /// <param name="a">Первое число</param>
  /// <param name="b">Второе число</param>
  /// <exception cref="Microsoft.AspNetCore.Http.BadHttpRequestException">Приложение очень просто поломать...</exception>
  /// <returns>Выражение с суммой</returns>
  public static string Sum(int a, int b)
  {
    return $"{a} = {b} = {a + b}";
  }
}
