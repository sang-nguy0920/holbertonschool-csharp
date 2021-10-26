using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {           
        double[,] matrix = new double[,] {{-1}};

        Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}
