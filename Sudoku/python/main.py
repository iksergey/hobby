from pprint import pprint


def empty_el_position(board: list):
    size = len(board)
    for x in range(0, size):
        for y in range(0, size):
            if board[x][y] == 0:
                return x, y
    return -1, -1


def get_column(board: list, y: int):
    size = len(board)
    temp = []
    for x in range(size):
        temp.append(board[x][y])
    return temp


def valid_element_in_position(board: list, el: int, x: int, y: int):
    if el in board[x] or el in get_column(board, y):
        return False

    row = (x // 3) * 3
    col = (y // 3) * 3
    for r in range(row, row+3):
        for c in range(col, col+3):
            if board[r][c] == el:
                return False
    return True


def fill(board: list):
    row, col = empty_el_position(board)
    if row == -1:
        return True
    for el in range(1, 10):
        if valid_element_in_position(board, el, row, col):
            board[row][col] = el
            if fill(board):
                return True
        board[row][col] = 0
    return False


def board_print(board: list):
    print("\033[H\033[J", end='')
    i = 1
    j = 1
    for line in board:
        j = 1
        for item in line:
            if j % 3 == 0:
                print(f"{item}   ", end='')
            else:
                print(f"{item} ", end='')
            j += 1

        if i % 3 == 0:
            print("\n")
        else:
            print()
        i += 1


board = [[1, 0, 0, 0, 0, 0, 0, 0, 0],
         [0, 2, 0, 0, 0, 0, 0, 0, 0],
         [0, 0, 3, 0, 0, 0, 0, 0, 0],

         [0, 0, 0, 4, 0, 0, 0, 0, 0],
         [0, 0, 0, 0, 5, 0, 0, 0, 0],
         [0, 0, 0, 0, 0, 6, 0, 0, 0],

         [0, 0, 0, 0, 0, 0, 7, 0, 0],
         [0, 0, 0, 0, 0, 0, 0, 8, 0],
         [0, 0, 0, 0, 0, 0, 0, 0, 9]]


res = fill(board)
board_print(board)
# pprint(Print(board))
print(f"res: {res}")
