using _1Task_MulProg;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Matrix Multiplication Program");

        var a = Utils.GetMatrixFromConsole("A");
        var b = Utils.GetMatrixFromConsole("B");

        Console.WriteLine("Matrix A:");
        Utils.PrintMatrix(a);

        Console.WriteLine("Matrix B:");
        Utils.PrintMatrix(b);

        var result = CalculationUnit.MatrixMultiplication(a, b);
        Console.WriteLine("Product of matrices:");
        Utils.PrintMatrix(result);

        Console.ReadLine();
    }
}