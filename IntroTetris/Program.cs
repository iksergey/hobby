using static System.Console;

WriteLine($"Размер терминала: {WindowWidth}x{WindowHeight}");
WriteLine("Нажмите любую клавишу...");
Console.ReadKey();
CursorVisible = false; // Console.CursorVisible = false;
// Логика игры
void Figure(int x, int y)
{
  Clear();
  for (int i = x - 1; i <= x + 1; i++)
  {
    for (int j = y - 1; j <= y + 1; j++)
    {
      SetCursorPosition(i, j);
      Write("◻︎");
    }
  }
}

// Положение. 
// Нужно обрабатывать значения выхода за границы
int x = Console.WindowHeight / 2; //  по горизонтали. Чем больше - тем правее 
int y = 2;  //  по вертикали. Чем больше - тем ниже

// Логика отрисовки всего
new Thread(() =>
{
  while (true)
  {
    Figure(x, y);
    Thread.Sleep(500); // Задержка отрисовки. 0.5 секунды
    if (++y > 15) y = 1;
  }
}).Start();

// Логика проверки нажатия кнопок

while (true)
{
  var key = ReadKey(true).Key;
  if (key == ConsoleKey.LeftArrow)
  {
    Figure(--x, y);
  }
  if (key == ConsoleKey.RightArrow)
  {
    Figure(++x, y);
  }
}