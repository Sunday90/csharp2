using System;

namespace csharp.ru {
public class Program {

public static void Main(string[] args) {
    //method1();   
    //method2(); 
    //method3();
    //method4();
    method5();
}

static void method1() {
    int cols = 4;
    int rows = 5;
    int[,] array = getArray(cols, rows);



Console.WriteLine();


        for (int row = 0; row < rows; row++)
        {
            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = i + 1; j < cols; j++)
                {
                    if (array[row, i] < array[row, j])
                    {
                        int temp = array[row, i];
                        array[row, i] = array[row, j];
                        array[row, j] = temp;
                    }
                }
            }
        }
    

    for(int i=0;i < rows;i++) {
        for(int j=0;j < cols;j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }

}

        static int[,] getArray(int cols, int rows) {
        Random random = new Random();
        int [,] array = new int [rows, cols];

        for(int i=0;i < rows;i++) {
            for(int j=0;j < cols;j++){
            array[i,j] = random.Next(10,100);
            Console.Write(array[i,j] + " ");
            }
        Console.WriteLine();
        }
        return array;
    }



        static void method2() {

            int cols = 4;
            int rows = 5;
            int[,] array = getArray(cols, rows);

            int[] amounts =  new int[rows];

        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int row = 0; row < rows; row++)
        {
            int sum = 0;
            for (int col = 0; col < cols; col++)
            {
                sum += array[row, col];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = row;
            }
        }

        Console.WriteLine("Минимальная сумма - " + minSum + " в строке " + (minSumRow + 1));
}



static void method3() {
    int[,] array1 = getArray(2,2);
    int[,] array2 = getArray(2,2);


        int cols1 = array1.GetLength(1);
        int rows2 = array2.GetLength(0);

        if (cols1 != rows2)
        {
            Console.WriteLine("Невозможно умножить матрицы: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            return;
        }

        int rows1 = array1.GetLength(0);
        int cols2 = array2.GetLength(1);

        int[,] resultMatrix = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += array1[i, k] * array2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }


        Console.WriteLine("Произведение матриц: \n");

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(resultMatrix[i,j] + " ");

            }
            Console.WriteLine();
        }

}


static void method4() {
    Random random = new Random();
        int [,,] array = new int [2, 2, 2];

        for(int i=0;i < 2;i++) {
            for(int j=0;j < 2;j++){
               for(int k=0;k < 2;k++){ 
            array[i,j,k] = random.Next(10,100);
            Console.Write(array[i,j,k] + " (" + i + "," + j + "," + k + ") ");
            }
        Console.Write(" ");
        }
        Console.WriteLine();
        }
}


static void method5() {
int[,] array = new int[4,4];

        int value = 1;
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int rowStart = 0;
        int rowEnd = rows - 1;
        int colStart = 0;
        int colEnd = cols - 1;

        while (rowStart < rowEnd && colStart < colEnd)
        {
            for (int col = colStart; col < colEnd; col++)
            {
                array[rowStart, col] = value++;
            }
            rowStart++;

            for (int row = rowStart; row < rowEnd; row++)
            {
                array[row, colEnd] = value++;
            }
            colEnd--;

            if (rowStart < rowEnd)
            {
                for (int col = colEnd; col > colStart; col--)
                {
                    array[rowEnd, col] = value++;
                }
                rowEnd--;
            }


            if (colStart < colEnd)
            {
                for (int row = rowEnd; row > rowStart; row--)
                {
                    array[row, colStart] = value++;
                }
                colStart++;
            }
        }


        for(int i=0;i<rows;i++) {
            for(int j=0;j<cols;j++) {
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
    }

}
}
