package BooleanLogicalOperators.java;

public class App {
  public static void main(String[] args) {

    int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

    if (numbers.length > 10 & numbers[9] == 1990) {
      System.out.println("yes");
    } else {
      System.out.println("no");
    }
  }
}
