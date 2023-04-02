long counter = 0;

void M1()
{
  #region ToDo
  // Interlocked.Increment(ref counter);
  #endregion
  Console.WriteLine($"  M1 Start - {Thread.CurrentThread.GetHashCode()}");
  counter++;
  Thread.Sleep(Random.Shared.Next(80, 85));
  #region ToDo
  // Interlocked.Decrement(ref counter);
  #endregion
  counter--;
}

// Проверка количества запущенных потоков. 
void Report()
{
  while (true)
  {
    long number = Interlocked.Read(ref counter);
    Console.WriteLine($"{number} поток(ов) активно. counter = {counter} ");
    Thread.Sleep(100);
  }
}


var reporter = new Thread(Report) { IsBackground = true };
reporter.Start();

var threads = new Thread[150];
for (uint i = 0; i < threads.Length; ++i)
{
  threads[i] = new Thread(M1);
  threads[i].Start();
}

Thread.Sleep(2500);
Console.WriteLine("stop");