public class EquilateralTriangle {
    private double sideLength;
    //конструктори
    public EquilateralTriangle() {
        this.sideLength = 1;
    }

    public EquilateralTriangle(double sideLength) {
        this.sideLength = sideLength;
    }

    public EquilateralTriangle(EquilateralTriangle other) {
        this.sideLength = other.sideLength;
    }

    public double getSideLength() {
        return sideLength;
    }

    public void setSideLength(double sideLength) {
        this.sideLength = sideLength;
    }
    //периметр
    public double getPerimeter() {
        return 3 * sideLength;
    }
    //площа
    public double getArea() {
        return Math.sqrt(3) / 4 * sideLength * sideLength;
    }
    //чи існує трикутник
    public boolean exists() {
        return sideLength > 0;
    }
}
