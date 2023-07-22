import java.util.ArrayList;
import java.util.List;

public class Demo {
  public static void main(String[] args) {
    TextDocument document = new TextDocument();

    System.out.println(document); // >><<
    document.append("1");
    System.out.println(document); // >>1<<
    document.append("2");
    System.out.println(document); // >>1 2<<

    document.undo();
    System.out.println(document); // >>1<<
    document.undo();
    document.undo();
    document.undo();
    document.undo();
    document.undo();
    System.out.println(document); // >><<

    document.redo();
    System.out.println(document); // >>1<<
    document.redo();
    System.out.println(document); // >>1 2<<
    document.redo();
    document.redo();
    document.redo();
    document.redo();
    System.out.println(document); // >>1 2<<

    document.append("4");
    System.out.println(document); // >>1 2 4<<
    document.undo();
    System.out.println(document); // >>1 2<<

    document.redo();
    document.redo();
    document.redo();
    System.out.println(document); // >>1 2 4<<
    document.undo();
    document.redo();
    document.redo();
    System.out.println(document); // >>1 2 4<<

    // #region fail
    // document.undo();
    // document.undo();
    // System.out.println(document); // >>1<<
    // document.append("10");
    // document.append("11");
    // System.out.println(document); // >>1 10 11<<
    // document.undo();
    // System.out.println(document); // >>1 10<<
    // #endregion
  }
}

class Memento {
  public String text;

  public Memento(String text) {
    this.text = text;
  }
}

class TextDocument {
  private int index;
  private String text;
  private List<Memento> mementos;

  public TextDocument() {
    index = -1;
    mementos = new ArrayList<>();

    this.text = "";
    save();
  }

  private void save() {
    mementos.add(new Memento(this.text));
    index++;
  }

  public void append(String s) {
    text += s + " ";
    save();
  }

  @Override
  public String toString() {
    return String.format(">>%s<<", this.text.trim());
  }

  public void undo() {
    if (index - 1 < 0)
      return;
    index--;
    setState();
  }

  public void redo() {
    if (index + 1 >= mementos.size()) {
      return;
    }
    index++;
    setState();
  }

  private void setState() {
    var state = this.mementos.get(index);
    this.text = state.text;
  }
}