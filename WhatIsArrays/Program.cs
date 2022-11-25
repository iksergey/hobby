using static System.Console;

Clear();

const int rows = 7;
const int columns = 5;
const int size = rows * columns;

int[] matrix = new int[size];
// int[] matrix = Enumerable.Range(0, size).ToArray();

void Print()
{
  for (int i = 0; i < size; i++)
  {
    if (i % columns == 0) WriteLine();
    Write($"{matrix[i],3}");
  }
  Console.WriteLine();
  Console.WriteLine();
}
Print();

void Set(int row, int column, int value)
{
  int position = row * columns + column;
  //  Console.WriteLine($"position: {position}");
  matrix[position] = value;
}

Set(1, 1, 1);
Set(1, 4, 2);
Set(2, 2, 3);
Set(5, 3, 4);
Set(6, 4, 5);

Print();

int Get(int row, int column)
{
  if (row >= rows || column >= columns)
    throw new IndexOutOfRangeException("Всё плохо");
  int position = row * columns + column;
  return matrix[position];
}

WriteLine($"{Get(1, 1)}");
WriteLine($"{Get(1, 4)}");
WriteLine($"{Get(6, 4)}");
WriteLine($"{Get(3, 2)}");

// WriteLine($"{Get(0, 12)}");
