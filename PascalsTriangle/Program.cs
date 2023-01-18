using System.Text;
using static System.Console;

const int cellWidth = 1;

void FillTriangle(double[,] t)
{
  int side = t.GetLength(0);

  for (int i = 0; i < side; i++)
  {
    t[i, 0] = 1;
    t[i, i] = 1;
  }

  for (int i = 2; i < side; i++)
    for (int j = 1; j <= i; j++)
      t[i, j] = t[i - 1, j - 1] + t[i - 1, j];
}

void PrintTriangle(double[,] t)
{
  int side = t.GetLength(0);
  for (int i = 0; i < side; i++)
  {
    for (int j = 0; j < side; j++)
      if (t[i, j] != 0)
        Write($"{t[i, j],cellWidth}");
    WriteLine();
  }
}

void MagicPrintV1(double[,] pas)
{
  int row = pas.GetLength(0);
  int col = cellWidth * row;

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j <= i; j++)
    {
      SetCursorPosition(col, i + 1);
      if (pas[i, j] != 0)
        Write("🔶");
      col += cellWidth * 2;
      Thread.Sleep(100);
    }

    col = cellWidth * row - cellWidth * (i + 1);
    WriteLine();
  }
}

void MagicPrintV2(double[,] pas)
{
  int row = pas.GetLength(0);
  int col = cellWidth * row;
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j <= i; j++)
    {
      SetCursorPosition(col, i + 1);
      if (pas[i, j] % 2 != 0)
        WriteLine("🔶");
      else
        WriteLine(" ");
      col += cellWidth * 2;
      Thread.Sleep(100); // 100 - задержка вывода
    }

    col = cellWidth * row - cellWidth * (i + 1);
    WriteLine();
  }
}

// Работает только для n < 10
string GetPolynomial(double[,] triangle, int n)
{
  StringBuilder sb = new();
  char[] pow = "⁰¹²³⁴⁵⁶⁷⁸⁹".ToCharArray();

  for (int i = 0; i <= n; i++)
  {
    double k = triangle[n, i];

    string kof = $"{k}";
    if (k != 1) sb.Append(kof);

    if (n - i != 0)
    {
      sb.Append("a");
      char powA = pow[n - i];
      if (n - i != 1) sb.Append(powA);
    }
    if (i != 0)
    {
      sb.Append("b");
      char powB = pow[i];
      if (i != 1) sb.Append(powB);
    }
    if (i != n) sb.Append("+");
  }
  return sb.ToString();
}

Clear();
int row = 16;
double[,] pascal = new double[row, row];

CursorVisible = false;

FillTriangle(pascal);
MagicPrintV1(pascal);
MagicPrintV2(pascal);
MagicPrintV1(pascal);

// WriteLine(GetPolynomial(pascal, 6));