using static System.Console;

#region Массив массивов, задача

// ┌───────────────┐
// │ 0   0   0   0 │  0 строка
// │ 0   0   0   0 │  1 строка
// │ 0   0   0   0 │  2 строка
// └───────────────┘
//   0   1   2   3
//     столбец
//
// int[,] table = new int[3, 4];
// 
// Пример задачи:
// Нужно вести учёт в рабочее время (с 8.00 до 19.59) каждые 5 минут
// В нерабочее (с 20.00 до 7.59) - каждые 15 минут

int hour = 24;
int interval = 60 / 5;
int[,] table = new int[hour, interval];

for (int i = 0; i < table.GetLength(0); i++)
{
  Write($"{i,2}-й час: ");
  for (int j = 0; j < table.GetLength(1); j++)
  {
    Write($"{table[i, j]} ");
  }
  WriteLine();
}

#endregion

#region Формирование
WriteLine("Enter для продолжения");
ReadLine();
Clear();

for (int i = 0; i < table.GetLength(0); i++)
{
  ForegroundColor = ConsoleColor.Gray;
  Write($"{i,2}-й час: ");
  for (int j = 0; j < table.GetLength(1); j++)
  {
    if (i < 8 || i >= 18)
      if (j > 4) ForegroundColor = ConsoleColor.Red;
      else ForegroundColor = ConsoleColor.Gray;
    else ForegroundColor = ConsoleColor.Gray;

    Write($"{table[i, j]} ");
  }
  WriteLine();
}

ForegroundColor = ConsoleColor.Gray;

//#endregion


#endregion

#region Решение:
WriteLine("Enter для продолжения");
ReadLine();
Clear();

int[][] log = new int[hour][];

//log[0] = new int[60 / 15];
//...
//log[7] = new int[60 / 15];
//log[8] = new int[60 / 5];
//...
//log[19] = new int[60 / 5];
//log[20] = new int[60 / 15];
//...
//log[23] = new int[60 / 15];


// 2809 - начальное число для ГПСЧ, 
// чтобы при перезапуске числа выдавались одинаковые 
Random random = new Random(2809);

for (int i = 0; i < hour; i++)
{
  if (i >= 8 && i <= 19)
    log[i] = new int[60 / 5];
  else
    log[i] = new int[random.Next(5, 20)];
}

for (int i = 0; i < log.Length; i++)
{
  Write($"{i,2}-й час: ");
  for (int j = 0; j < log[i].Length; j++)
  {
    Write($"{log[i][j]} ");
  }
  WriteLine();
}

#endregion

#region Отсылка к треугольнику Паскаля
WriteLine("Enter для продолжения");
ReadLine();
Clear();

int count = 15;

int[][] jagged = new int[count][];

for (int lineIndex = 0; lineIndex < count; lineIndex++)
{
  int lineCount = lineIndex + 1;
  jagged[lineIndex] = new int[lineCount];
}

foreach (var row in jagged)
{
  foreach (var item in row)
  {
    Console.Write($"{item,4}");
  }
  Console.WriteLine();
}

#endregion


