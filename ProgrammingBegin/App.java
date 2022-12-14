import java.util.Scanner;

public class App {

  public static void main(String[] args) {

    Scanner scanner = new Scanner(System.in);

    System.out.print("x = ");
    int x = scanner.nextInt();
    System.out.print("y = ");
    int y = scanner.nextInt();

    if (y != 0) {
      System.out.println(x / y);
    } else {
      System.out.println("NaN");
    }

    scanner.close();

  }
}