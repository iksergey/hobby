let numbers: [Int] = [1, 2, 3, 4, 5, 6, 7]

// ошибка выполнения
if numbers.count > 10 & numbers[9] == 1990 {
  print("yes")
}
else {
  print("no")
}

// работает без ошибок
if numbers.count > 10 && numbers[9] == 1990 {
  print("yes")
}
else {
  print("no")
}
