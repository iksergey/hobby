void Add(ref int set, params int[] elements)
{
  foreach (var item in elements)
  {
    set |= (1 << item);
  }
}

void Print(string text, int set)
{
  Console.Write(text);
  for (int k = 0; k < 32; k++)
  {
    if ((set & (1 << k)) != 0)
      Console.Write($"{k} ");
  }
  Console.WriteLine();
}

Console.Clear();
int A = 0;
Add(ref A, 1, 3, 5, 7, 11, 22);
Print("A: ", A); // A: 1 3 5 7 11 22 

int B = 0;
Add(ref B, 1, 4, 5, 6, 7, 22);
Print("B: ", B); // B: 1 4 5 6 7 22 

int C = A | B;
Print("А ∪ B: ", C); // А ∪ B: 1 3 4 5 6 7 11 22 

int D = A & B;
Print("А ∩ B: ", D); // А ∩ B: 1 5 7 22 


int E = ~A;
Print("¬A: ", E); // ¬A: 0 2 4 6 8 9 10 ... 30 31 

int F = A & ~B;
Print(@"A \ B: ", F); // A \ B: 3 11

System.Console.WriteLine("====");
for (int b = 0; b < (1 << 3); b++)
{
  Print($"{b}: ", b);
}
// 0: 
// 1: 0
// 2: 1
// 3: 0 1
// 4: 2
// 5: 0 2
// 6: 1 2
// 7: 0 1 2 