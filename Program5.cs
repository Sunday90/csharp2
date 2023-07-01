using System;

namespace csharp.ru {
public class Program {

public static void Main(string[] args) {
Console.WriteLine(method1());
Console.WriteLine(method2());
Console.WriteLine(method3());

}

public static int method1() {
    int[] list = new int[10];
    Random rnd = new Random();

    for (int i=0; i < 10; i++) {
    list[i] = rnd.Next(100,999);
    }

    List<Int32> list2 = list.ToList<Int32>();
    return list2.FindAll(i => i % 2 == 0).Count;
}


public static int method2() {
    int[] list = new int[10];
    Random rnd = new Random();
    int summ = 0;

    for(int i=0; i < 10; i++) {
        list[i] = rnd.Next(1000);
        if (i % 2 == 1) {
            summ += list[i];
        }
    }

    return summ;
}


public static double method3() {
    double[] list = {1.12, 2.23, 10.12, 12.11};
    double min = list[0], max = list[0];

    for(int i=0; i< list.Length; i++) {
        if (list[i] > max) {
            max = list[i];
        }
        if (list[i] < min) {
            min = list[i];
        }
    }

    return max - min;

}
}
}
