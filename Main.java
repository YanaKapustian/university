public class Main {
    public static void main(String args[]) {
      EquilateralTriangle triangle = new EquilateralTriangle(5);
      System.out.println(triangle.getPerimeter());
      triangle.setSideLength(3);
      System.out.println(triangle.getArea());
    }
}
