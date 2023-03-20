using System.Diagnostics;

int size = 20;
int m = 5;

int[] array = Enumerable.Range(1, size)
                        .Select(e => Random.Shared.Next(10))
                        .ToArray();

Stopwatch sw = new();

/// Первый способ
sw.Start();

int[] sums = new int[array.Length - m + 1];

for (int i = 0; i <= size - m; i++)
{
  int t = 0;
  for (int j = i; j < i + m; j++) t += array[j];
  sums[i] = t;
}

int max = sums[0];
int k = 0;
for (int i = 0; i < sums.Length; i++)
{
  if (sums[i] > max) { max = sums[i]; k = i; }
}
Console.WriteLine(max);
sw.Stop();

Console.WriteLine($"Способ 1: {sw.ElapsedMilliseconds} ms");
sw.Reset(); sw.Start();


/// Второй способ

max = 0;

for (int i = 0; i <= size - m; i++)
{
  int t = 0;
  for (int j = i; j < i + m; j++) t += array[j];
  if (t > max) max = t;
}
Console.WriteLine(max);

sw.Stop();
Console.WriteLine($"Способ 2: {sw.ElapsedMilliseconds} ms");
sw.Reset(); sw.Start();

/// Третий способ

max = 0;
for (int i = 0; i < m; i++) max += array[i];

int temp = max;

for (int i = 1; i <= size - m; i++)
{
  temp = temp - array[i - 1] + array[i + (m - 1)];
  if (temp > max) max = temp;
}

Console.WriteLine(max);

sw.Stop();
Console.WriteLine($"Способ 3: {sw.ElapsedMilliseconds} ms");