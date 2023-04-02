class Program
{
  static void Main()
  {
    var thread = new Thread(M1);
    thread.Start();
    thread.Join();
    Console.WriteLine($"MainHashCode {Thread.CurrentThread.GetHashCode()}");
  }

  #region TLocalStorage
  // [ThreadStatic]
  #endregion
  public static int counter = 0;

  public static void M1()
  {
    if (counter < 5)
    {
      Console.WriteLine($"{++counter} - M1 Start - {Thread.CurrentThread.GetHashCode()}");
      var thread = new Thread(M1);
      thread.Start();
      thread.Join();
    }
    Console.WriteLine($"M1HashCode {Thread.CurrentThread.GetHashCode()}");
  }
}
