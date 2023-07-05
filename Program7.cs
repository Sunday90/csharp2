using System;

namespace csharp.ru {
public class Program {

public static void Main(string[] args) {
    //method2(1,2);
    //method2(10,1);
    method3();
}

public static double[,] method1() {
    int m = 3;
    int n = 4;

    double [,] array = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i,j] = random.NextDouble();
        }
    }

    return array;

}

public static void method2(int m, int n) {
    double [,] array = method1();
    int a = m / n;
    int b = m % n;

    try {
        Console.WriteLine(array[a, b]);
    }
    catch (Exception e) {
        Console.WriteLine("Нет такого элемента");
    }
}


public static void method3() {

     int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

         int rows = array.GetLength(0);
        int cols = array.GetLength(1);

    int[] averageValues = new int[rows];

        for (int col = 0; col < cols; col++)
        {
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                sum += array[row, col];
                Console.Write(array[row, col] + " ");
            }
            averageValues[col] = sum / rows;
            Console.WriteLine();
        }


        for (int col = 0; col < cols; col++)
        {
            Console.WriteLine(averageValues[col]);
        }
    }

}

}
