array = [1, 5, 4, 3, 6, 7, 0]

posMin = 0
posMax = 0
index = 0
size = len(array)

while index < size:
    if array[index] > array[posMax]:
        posMax = index

    if array[index] < array[posMin]:
        posMin = index
    index += 1

print(f"posMax: {posMax} posMin: {posMin}")
