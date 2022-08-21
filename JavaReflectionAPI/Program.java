import java.lang.reflect.Field;

public class Program {

  public static void main(String[] args)
      throws NoSuchFieldException, SecurityException, IllegalArgumentException, IllegalAccessException {

    Worker w = new Worker();
    String workerLastName = w.getlName();
    System.out.println(workerLastName);
    // Значение по умолчанию
    Field[] fields = w.getClass().getDeclaredFields();

    for (Field f : fields) {
      System.out.println("  >>  " + f.getName());
    }
    // >> fName
    // >> lName
    // >> age

    Field field = w.getClass().getDeclaredField(fields[1].getName());
    field.setAccessible(true);
    field.set(w, (String) "Инкапсуляции больше нет");

    System.out.println(w.getlName());
    // Инкапсуляции больше нет
  }
}

class Worker {
  private String fName;
  private String lName;
  private int age;

  public Worker() {
    lName = "Значение по умолчанию";
  }

  public String getlName() {
    return lName;
  }
}