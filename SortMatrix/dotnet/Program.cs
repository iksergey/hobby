
//! Данный пример не адаптирован для общего случая
//! сортировки зубчатого массива

void Print(int[][] array)
{
  foreach (var l in array)
  {
    foreach (var e in l)
    {
      Console.Write($"{e,2}");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

void SortColumn(int[][] array, int column)
{
  int size = array.Length; // size = rows

  for (int i = 0; i < size - 1; i++)
  {
    int minPos = i;
    for (int j = i + 1; j < size; j++)
    {
      if (array[j][column] < array[minPos][column])
        minPos = j;
    }
    // обмен двух элементов местами
    (array[i][column], array[minPos][column]) =
    (array[minPos][column], array[i][column]);
  }
}

void SortLine(int[] array)
{
  int size = array.Length;

  for (int i = 0; i < size - 1; i++)
  {
    int minPos = i;
    for (int j = i + 1; j < size; j++)
    {
      if (array[j] < array[minPos])
        minPos = j;
    }
    // обмен двух элементов местами
    (array[i], array[minPos]) =
    (array[minPos], array[i]);
  }
}

void Sort(int[][] matrix)
{
  // если в матрице нет ни одной строки
  if (matrix.Length == 0) return;

  // если в матрице есть хотя бы одна строка
  int columns = matrix[0].Length;

  // полагаем, что везде столбцов одинаковое количество
  for (int column = 0; column < columns; column++)
  {
    SortColumn(matrix, column);
  }
}

int[][] matrix =
{
  new int[] { 3, 4, 7, 4, 1, 5 },
  new int[] { 1, 9, 1, 5, 2, 4 },
  new int[] { 6, 4, 6, 2, 9, 1 },
  new int[] { 2, 1, 2, 1, 5, 3 }
};

Print(matrix);
Sort(matrix);
Print(matrix);


int[] array = new int[] { 1, 2, 31, 2, 3, 9, 1, 4, 2 };
Console.WriteLine(String.Join(' ', array));
SortLine(array);
Console.WriteLine(String.Join(' ', array));
