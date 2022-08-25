int TimeRandom()
{
  int value = DateTime.Now.Millisecond;
  return value % 10;
}

int TickCountRandom()
{
  int value = Environment.TickCount;
  return value % 10;
}

int[] NumberRandom(int count, int value)
{
  int[] values = new int[count];

  for (int i = 0; i < count; i++)
  {
    value = value * value;
    values[i] = value % 10;
    while (value > 10000) value /= 10;
    //Console.WriteLine($"value: {value}");

  }
  return values;
}

int[] LehmerRandom(int count, int a = 3, int c = 7, int m = 10)
{
  int x = 2;
  int[] values = new int[count];

  for (int i = 0; i < count; i++)
  {
    x = (a * x + c) % m;
    values[i] = x;
  }
  return values;
}

Console.WriteLine($"{String.Join(' ', LehmerRandom(10))}");

var numbers = NumberRandom(1000, 1237);
var report = numbers.GroupBy(e => e)
                    .OrderBy(e => e.Key);

foreach (var item in report)
{
  Console.WriteLine($"{item.Key}: {item.Count()} р.");
}