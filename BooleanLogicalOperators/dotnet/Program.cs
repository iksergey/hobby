int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

// ошибка выполнения
if (numbers.Length > 10 & numbers[9] == 1990)
{
  Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
}

// работает без ошибок
if (numbers.Length > 10 && numbers[9] == 1990)
{
  Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
}
