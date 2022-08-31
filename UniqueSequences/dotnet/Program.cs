int[] GetUniqueSequencesWithRandomPos(int count, int startValue = 10, int length = 90)
{
  //int step = 0; // логика подсчета шагов
  int[] set = new int[count];
  int index = 0;
  int size = set.Length;
  while (index < size)
  {
    int value = 0;
    while (Array.IndexOf(set, value) != -1)
    {
      value = Random.Shared.Next(startValue, startValue + length);
      //step++;
    }
    set[index++] = value;
  }
  //Console.WriteLine($"Потребовалось шагов: {step}");
  return set;
}

int[] GetUniqueSequencesWithMix(int count, int startValue = 10)
{
  int[] set = new int[count];
  int size = set.Length;
  for (int i = 0; i < size; i++)
    set[i] = startValue + i;

  for (int i = 0; i < size - 1; i++)
  {
    int pos = Random.Shared.Next(i + 1, size);
    (set[i], set[pos]) = (set[pos], set[i]);
  }
  return set;
}
int[] array;
// // Тесты
// for (int i = 0; i < 10; i++)
// {
//   array = GetUniqueSequencesWithRandomPos(count: 90);
// }

array = GetUniqueSequencesWithMix(90);
System.Console.WriteLine(string.Join(" ", array));