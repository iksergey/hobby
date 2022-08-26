numbers = [1, 2, 3, 4, 5, 6, 7]

# ошибка выполнения
if len(numbers) > 10 & numbers[9] == 1990:
    print("yes")
else:
    print("no")


# работает без ошибок
if len(numbers) > 10 and numbers[9] == 1990:
    print("yes")
else:
    print("no")
