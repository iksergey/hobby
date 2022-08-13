public class App {

  static int[] EmptyElPosition(int[][] board) {
    int size = board.length;
    for (int x = 0; x < size; x++)
      for (int y = 0; y < size; y++)
        if (board[x][y] == 0)
          return new int[] { x, y };
    return new int[] { -1, -1 };
  }

  static int[] GetColumn(int[][] board, int y) {
    int size = board.length;
    int[] temp = new int[size];
    for (int x = 0; x < size; x++)
      temp[x] = board[x][y];
    return temp;
  }

  static int indexOf(int[] arr, int val) {
    for (int i = 0; i < arr.length; i++) {
      if (arr[i] == val)
        return i;
    }
    return -1;
  }

  static boolean ValidElementInPosition(int[][] board, int el, int x, int y) {

    var column = GetColumn(board, y);
    if (indexOf(board[x], el) != -1
        || indexOf(column, el) != -1)
      return false;

    int row = (x / 3) * 3;
    int col = (y / 3) * 3;
    for (int r = row; r < row + 3; r++)
      for (int c = col; c < col + 3; c++)
        if (board[r][c] == el)
          return false;
    return true;
  }

  static boolean Fill(int[][] board) {
    var pos = EmptyElPosition(board);
    int row = pos[0];
    int col = pos[1];
    if (row == -1)
      return true;
    for (int el = 1; el < 10; el++) {
      if (ValidElementInPosition(board, el, row, col)) {
        board[row][col] = el;
        if (Fill(board))
          return true;
      }
      board[row][col] = 0;
    }
    return false;
  }

  static void Print(int[][] board) {
    System.out.print("\033[H\033[J");
    int i = 1;
    int j = 1;

    for (var line : board) {
      j = 1;
      for (var item : line) {
        if (j % 3 == 0)
          System.out.printf("%d   ", item);
        else
          System.out.printf("%d ", item);
        j += 1;
      }
      if (i % 3 == 0)
        System.out.println("\n");
      else
        System.out.println();
      i += 1;
    }
  }

  public static void main(String[] args) {

    int[][] board = {

        new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        new int[] { 0, 2, 0, 0, 0, 0, 0, 0, 0 },
        new int[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 },

        new int[] { 0, 0, 0, 4, 0, 0, 0, 0, 0 },
        new int[] { 0, 0, 0, 0, 5, 0, 0, 0, 0 },
        new int[] { 0, 0, 0, 0, 0, 6, 0, 0, 0 },

        new int[] { 0, 0, 0, 0, 0, 0, 7, 0, 0 },
        new int[] { 0, 0, 0, 0, 0, 0, 0, 8, 0 },
        new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 9 },
    };

    var res = Fill(board);
    Print(board);
    System.out.printf("res: %b\n", res);
  }
}