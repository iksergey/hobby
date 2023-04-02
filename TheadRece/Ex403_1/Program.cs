void M1()
{
  Console.WriteLine($"M1HashCode start {Thread.CurrentThread.GetHashCode()}");
  for (int i = 0; i < 100; i++)
  {
    Thread.Sleep(20);
    Console.Write(".");
  }
  Console.WriteLine($"\nM1HashCode end {Thread.CurrentThread.GetHashCode()}");
}

Console.WriteLine($"\nMainHashCode start {Thread.CurrentThread.GetHashCode()}");

var thread = new Thread(M1);
thread.Start();

#region Join
//Ожидание первичным потоком, завершения работы вторичного потока
thread.Join();
#endregion

for (int i = 0; i < 100; i++)
{
  Thread.Sleep(20);
  Console.Write("-");
}

Console.WriteLine($"\nMainHashCode end {Thread.CurrentThread.GetHashCode()}");