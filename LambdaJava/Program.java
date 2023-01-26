import java.util.ArrayList;
import java.util.function.Predicate;

public class Program {
  public static void main(String[] args) {
    int[] numbers = new int[] { 1, 2, 5, 3, 1, 12, 35, 28, 13, 14 };
    var n2 = getItemsDividedBy2(numbers);
    System.out.println(n2);
    var n7 = getItemsDividedBy7(numbers);
    System.out.println(n7);
    // var n5 = getItems(new DividedBy2(), numbers);
    // System.out.println(n5);
    var n3 = getItems(e -> e % 3 == 0, numbers);
    System.out.println(n3);
  }

  static ArrayList<Integer> getItemsDividedBy2(int... numbers) {
    ArrayList<Integer> result = new ArrayList<>();
    for (Integer item : numbers)
      if (item % 2 == 0)
        result.add(item);
    return result;
  }

  static ArrayList<Integer> getItemsDividedBy7(int... numbers) {
    ArrayList<Integer> result = new ArrayList<>();
    for (Integer item : numbers)
      if (item % 7 == 0)
        result.add(item);
    return result;
  }

  // static ArrayList<Integer> getItems(Divided divided, int... numbers) {
  // ArrayList<Integer> result = new ArrayList<>();
  // for (Integer item : numbers)
  // if (divided.by(item))
  // result.add(item);
  // return result;
  // }

  static ArrayList<Integer> getItems(Predicate<Integer> divided, int... numbers) {
    ArrayList<Integer> result = new ArrayList<>();
    for (Integer item : numbers)
      if (divided.test(item))
        result.add(item);
    return result;
  }
}

interface Divided {
  boolean by(int value);
}

class DividedBy2 implements Divided {
  @Override
  public boolean by(int value) {
    return value % 5 == 0;
  }
}