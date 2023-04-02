void WriteString(string symbol, int count)
{
  for (int i = 0; i < count; i++)
  {
    Thread.Sleep(20);
    Console.Write(symbol);
  }
}

void M3()
{
  Console.WriteLine($"\nM3HashCode start {Thread.CurrentThread.GetHashCode()}");
  WriteString("3 ", 100);
  Console.WriteLine($"\nM3HashCode start {Thread.CurrentThread.GetHashCode()}");
}

void M2()
{
  Console.WriteLine($"\nM2HashCode start {Thread.CurrentThread.GetHashCode()}");
  WriteString("2 ", 100);

  var thread = new Thread(M3);
  thread.Start();
  //thread.Join();
  WriteString("2 ", 100);
  Console.WriteLine($"\nM2HashCode start {Thread.CurrentThread.GetHashCode()}");
}

Console.WriteLine($"MainHashCode start {Thread.CurrentThread.GetHashCode()}");
WriteString("1 ", 100);

var thread = new Thread(M2);
thread.Start();
//thread.Join();

WriteString("1 ", 100);
Console.WriteLine($"\nMainHashCode end {Thread.CurrentThread.GetHashCode()}");