import javax.swing.*;

public class JFrameUI extends JFrame {
  private JButton btn = new JButton("Click");

  public JFrameUI() {
    super("JFrame 1"); // Заголовок формы
    this.setBounds(0, 0, 250, 300); // Положение и размеры формы
    this.setLocationRelativeTo(null); // *центр экрана
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // *реакция после закрытия
    this.getContentPane().add(btn);

    btn.addActionListener((e) -> {
      String text = JOptionPane.showInputDialog("Data");
      JOptionPane.showMessageDialog(this, text + "!");
    });
  }
}