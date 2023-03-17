import java.util.Scanner;
public class lab2 {

	public static void main(String[] args) {
		int number, n;
		double a, b, c, x, res, r, d, l, s;
		Scanner scan = new Scanner(System.in);
		System.out.println("Enter the number of the task");
		number = scan.nextInt();
		
		switch(number) {
		case 1:
			System.out.print("Enter the value of a ");
			a = scan.nextInt();
			System.out.print("Enter the value of b ");
			b = scan.nextInt();
			System.out.print("Enter the value of c ");
			c = scan.nextInt();
			System.out.print("Enter the value of x ");
			x = scan.nextInt();
			
			if (x < 3 && b != 0) {
				res = a*x*x-b*x+c;
			} else if (x > 3 && b == 0) {
				res = (x-a)/(x-c);
			} else {
				res = x/c;
			}
			System.out.println("Result is " + res);
			break;
		case 2:
			System.out.println("Enter the radius of the circle ");
			r = scan.nextInt();
			d = r * 2;
			l = d * 3.14;
			s = 3.14 * r * r;
			System.out.println("Diameter is " + d);
			System.out.println("Length is " + l);
			System.out.println("Square is " + s);
			break;
		case 3:
			System.out.println("Enter the number of elements ");
			n = scan.nextInt();
			res = 0;
			for (int i = 1; i <= n; i++) {
				System.out.println("Enter the resistance of element " + i + " ");
				r = scan.nextDouble();
				res += r;
			}
			System.out.println("Total resistance of the circuit is " + res);
			break;
		case 4:
			System.out.println("Enter the value of n ");
			n = scan.nextInt();
			for (int i = 1; i * i <= n; i++) {
	            System.out.print(i + " ");
	        }
	        System.out.println();
	        int j = 1;
	        while (j * j <= n) {
	            j++;
	        }
	        System.out.println("The first integer whose square is greater than " + n + " is " + j);
			break;
		case 5:
			int tableSize = 10;
	    
	        System.out.println();
	        for (int i = 1; i <= tableSize; i++) {
	            for (int j1 = 1; j1 <= tableSize; j1++) {
	                System.out.printf("%d * %d = %2d   ", i, j1, i * j1);
	            }
	            System.out.println();
	        }
			break;
		}
		scan.close();
	}
}
