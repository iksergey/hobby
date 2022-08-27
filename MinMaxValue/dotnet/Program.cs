int[] array = { 1, 5, 4, 3, 6, 7, 0 };

int posMin = 0;
int posMax = 0;
int index = 0;
int size = array.Length;

while (index < size)
{
  if (array[index] > array[posMax]) posMax = index;

  if (array[index] < array[posMin]) posMin = index;

  index += 1;
}

Console.WriteLine($"posMax: {posMax} posMin: {posMin}");
