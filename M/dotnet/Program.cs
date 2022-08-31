//https://www.codewars.com/kata/5263a84ffcadb968b6000513/train/csharp

void Print(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);

  for (int x = 0; x < rows; x++)
  {
    for (int y = 0; y < columns; y++)
    {
      Console.Write($"{matrix[x, y],4}");
    }
    Console.WriteLine("");
  }
  Console.WriteLine("");
}

int[,] CreateAndFill(int rows, int columns)
{
  Random random = new Random(0);

  int[,] matrix = new int[rows, columns];
  for (int x = 0; x < rows; x++)
  {
    for (int y = 0; y < columns; y++)
    {
      matrix[x, y] = random.Next(10);
    }
  }
  return matrix;
}

int[,] MultiplicationMatrix(int[,] a, int[,] b)
{
  int m = a.GetLength(0),
      k = a.GetLength(1),
      n = b.GetLength(1);
  int[,] c = new int[m, n];
  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      for (int l = 0; l < k; l++)
        c[i, j] += a[i, l] * b[l, j];
  return c;
}

int m = 5, k = 3, n = 4;
var a = CreateAndFill(m, k);
var b = CreateAndFill(k, n);
var c = MultiplicationMatrix(a, b);

Print(a);
Print(b);
Print(c);