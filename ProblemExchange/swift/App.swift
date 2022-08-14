
// coins - монеты в кошельке
let coins = [ 5, 11, 17, 10 ]
// sum — сумма, которую требуется разменять
var sum = 26

// exchanges — массив, который хранит всё суммы,
// которые могут быть получены
var exchanges = Array (repeating: 0, count: sum + 1)

for i in 0...coins.count - 1 {
  for j in stride(from: sum, to: coins[i] + 1, by: -1) {
    if exchanges[j] == 0 && exchanges[j - coins[i]] != 0 {
      exchanges[j] = coins[i];
    }
  }
  if coins[i] <= sum && exchanges[coins[i]] == 0 {
    exchanges[coins[i]] = coins[i];
  }
}

var text = "Размен для \(sum) из \(coins): ";
if exchanges[sum] != 0 {
  while (sum != 0)
  {
    text += "\(exchanges[sum]) ";
    sum -= exchanges[sum];
  }
}
else
{
  text += "не существует";
}
print(text);
