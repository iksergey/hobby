using static System.Console;
using static System.String;

// coins - монеты в кошельке
int[] coins = new int[] { 2, 7, 3, 5 };
// sum — сумма, которую требуется разменять
int sum = 10;

// exchanges — массив, который хранит всё суммы,
// которые могут быть получены
int[] exchanges = new int[sum + 1];

for (int i = 0; i < coins.Length; i++)
{
  for (int j = sum; j >= coins[i] + 1; j--)
  {
    if (exchanges[j] == 0 && exchanges[j - coins[i]] != 0)
    {
      exchanges[j] = coins[i];
    }
  }
  if (coins[i] <= sum && exchanges[coins[i]] == 0)
  {
    exchanges[coins[i]] = coins[i];
  }
  System.Console.WriteLine($"[{Join(", ", exchanges)}]");
  ReadLine();
}

string text = $"Размен для {sum} из [{Join(", ", coins)}]: ";
if (exchanges[sum] != 0)
{
  while (sum != 0)
  {
    text += $"{exchanges[sum]} ";
    sum -= exchanges[sum];
  }
}
else
{
  text += $"не существует";
}
WriteLine(text);