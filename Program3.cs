using System;

namespace csharp.ru {
public class Program3 {

public static void Main(string[] args) {
    Console.WriteLine(method1("12321"));
    Console.WriteLine(method1("12345"));
    
    Console.WriteLine(method2(2,3,4,5,6,7));

    method3(8).ForEach( i => Console.Write(i + " "));
}

public static bool method1(String a) {
    if ((Int32.Parse(a[0].ToString()) == Int32.Parse(a[4].ToString())) && (Int32.Parse(a[1].ToString()) == Int32.Parse(a[3].ToString()))) {
        return true;
    }
    else return false;
}

public static double method2(int a, int b, int c, int d, int e, int f) {
    return Math.Sqrt(Math.Pow((b-a), 2) + Math.Pow((d-c), 2) + Math.Pow((f-e), 2));
}

public static List<Int32> method3(int a) {
    List<Int32> array = new List<Int32>();
    for(int i=1; i<a+1; i++) {
        array.Add(((int)Math.Pow(i, 3)));
    }
    return array;
}

}
}
