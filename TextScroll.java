import java.awt.*;
import java.applet.*;

public class TextScroll extends Applet implements Runnable {
   private Thread thread = null;
   private int currentX = 0;
   private int currentY = 0;
   private boolean isRunning = true;
   private String[] textArray = {"Перший рядок", "Другий рядок", "Третій рядок", "Четвертий рядок", "П'ятий рядок"};
   private int currentIndex = 0;
   private int direction = 0;
   private Font font = new Font("Arial", Font.BOLD, 14);

   public void start() {
      thread = new Thread(this);
      isRunning = true;
      thread.start();
   }

   public void stop() {
      isRunning = false;
      thread = null;
   }

   public void run() {
      while (isRunning) {
         try {
            Thread.sleep(1000);
         } catch (InterruptedException e) {
            e.printStackTrace();
         }

         if (direction == 0) {
            currentX += 5;
         } else {
            currentX -= 5;
         }

         if (currentX > getWidth()) {
            currentIndex = (currentIndex + 1) % textArray.length;
            currentX = -100;
            direction = (int)(Math.random() * 2);
         }

         repaint();
      }
   }

   public void paint(Graphics g) {
      g.setFont(font);
      g.setColor(Color.BLACK);
      g.drawString(textArray[currentIndex], currentX, currentY + 20);
   }
   
   public static void main(String[] args) {
      System.setProperty("java.awt.headless", "true");
      
      TextScroll applet = new TextScroll();
      applet.init();
      applet.start();
      
      Frame f = new Frame("Text Scroll Applet");
      f.add(applet);
      f.setSize(300, 100);
      f.setVisible(true);
   }
}
