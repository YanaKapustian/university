import java.util.Scanner;
import java.util.Arrays;
import java.util.Comparator;


public class lr3_kapustian {
	public static void printArray(int[][] array) {
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array[i].length; j++) {
                System.out.print(array[i][j] + " ");
            }
            System.out.println();
        }
    }

	public static void main(String[] args) {
		int number;
		Scanner scan = new Scanner(System.in);
		System.out.println("Enter the number of the task");
		number = scan.nextInt();
		
		switch(number) {
		case 1:
			double[] arr = { 5.6, 1.2, -3.4, 2.7, 6.8, -8.1, 4.5, 0.9 };
	        double A = -4.0;
	        double B = 4.0;
	        
	        int count = 0;
	        for (double num : arr) {
	            if (num >= A && num <= B) {
	                count++;
	            }
	        }
	        System.out.println("Number of items in the range [" + A + ", " + B + "]: " + count);
	        
	        int maxIndex = 0;
	        for (int i = 1; i < arr.length; i++) {
	            if (arr[i] > arr[maxIndex]) {
	                maxIndex = i;
	            }
	        }
	        double sum = 0.0;
	        for (int i = maxIndex + 1; i < arr.length; i++) {
	            sum += arr[i];
	        }
	        System.out.println("Sum of elements after the maximum element: " + sum);
	        
	        Comparator<Double> absComparator = Comparator.comparingDouble(Math::abs);
	        Double[] arrWrapper = Arrays.stream(arr).boxed().toArray(Double[]::new);
	        Arrays.sort(arrWrapper, absComparator.reversed());
	        double[] sortedArr = Arrays.stream(arrWrapper).mapToDouble(Double::doubleValue).toArray();
	        System.out.println("Array ordered in descending order of element modules: " + Arrays.toString(sortedArr));
	        break;
		case 2:
			int[][] array = {{5, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}};

	        // Print the original array
	        System.out.println("Original array:");
	        printArray(array);

	        // Check if there are odd numbers in the upper right and lower right corners
	        boolean hasOddNumbers = false;
	        if (array[0][array.length-1] % 2 != 0 || array[array.length-1][array.length-1] % 2 != 0) {
	            hasOddNumbers = true;
	        }
	        System.out.println("Are there odd numbers in the upper right and lower right corners? " + hasOddNumbers);

	        // Check if there are numbers ending in 5 in the upper left or lower left corners
	        boolean hasNumbersEndingIn5 = false;
	        if (array[0][0] % 10 == 5 || array[array.length-1][0] % 10 == 5) {
	            hasNumbersEndingIn5 = true;
	        }
	        System.out.println("Are there numbers ending in 5 in the upper left or lower left corners? " + hasNumbersEndingIn5);
			break;
		
		}
	
		scan.close();
	}
}
