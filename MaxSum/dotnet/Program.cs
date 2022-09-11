using System.Diagnostics;
using static System.Console;
Clear();
Random r = new Random(0);

Stopwatch st = new Stopwatch();
int result = 0;
long time = 0;

WriteLine("╔══════╦══════╦═══════╦═════════╗");
WriteLine("║    n ║ O(n) ║ O(n²) ║   O(n³) ║");
WriteLine("╠══════╬══════╬═══════╬═════════╣");

for (int count = 1000; count <= 9000; count += 1000)
{
  int[] arr = Enumerable.Range(1, count)
                        .Select(e => r.Next(-10, 10))
                        .ToArray();

  Write($"║ {count,4} ");
  st.Restart();
  Research3.MaxSum(arr);
  st.Stop();
  time = st.ElapsedMilliseconds;
  Write($"║{time,3}ms ");
  st.Restart();
  Research2.MaxSum(arr);
  st.Stop();
  time = st.ElapsedMilliseconds;

  Write($"║{time,4}ms ");
  st.Restart();
  Research1.MaxSum(arr);
  st.Stop();
  time = st.ElapsedMilliseconds;

  Write($"║{time,6}ms ║\n");

}
WriteLine("╚══════╩══════╩═══════╩═════════╝");
