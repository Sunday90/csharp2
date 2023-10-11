using System;

namespace csharp.ru {
public class Program {
 static int method1(int start, int end)
    {
        if (start > end)
        {
            return 0;
        }
        else
        {
            return start + method1(start + 1, end);
        }
    }

    static int method2(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return method2(m - 1, 1);
        }
        else
        {
            return method2(m - 1, method2(m, n - 1));
        }
    }

    public static void Main()
    {
        int M = 1;
        int N = 15;

        int sum = method1(M, N);

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна: {2}", M, N, sum);

        int result = method2(m, n);

        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }
}
