using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        double[] vectorOne2d = {8, -11};
        double[] vectorTwo2d = {-4, 9};
        double[] vectorOne3d = {14, -2, 0};
        double[] vectorTwo3d = {-3, 23, 50};
        double [] res1;
        double [] res2;

        res1 = VectorMath.Add(vectorOne2d, vectorTwo2d);
        res2 = VectorMath.Add(vectorOne3d, vectorTwo3d);

        Console.WriteLine("(" + res1[0] + ", " + res1[1] + ")");
        Console.WriteLine("(" + res2[0] + ", " + res2[1] + ", " + res2[2] + ")");
    }
}
