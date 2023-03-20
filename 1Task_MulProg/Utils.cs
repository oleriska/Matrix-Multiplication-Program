using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Utils
    {
    // method to get matrix from console
    public static int[,] GetMatrixFromConsole(string name)
        {
            Console.Write("Number of matrix rows {0}:    ", name);
            var n = int.Parse(Console.ReadLine());
            Console.Write("Number of matrix columns {0}: ", name);
            var m = int.Parse(Console.ReadLine());

            var matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write("{0}[{1},{2}] = ", name, i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }
    // метод для печати матрицы в консоль
    public static void PrintMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.RowsCount(); i++)
            {
                for (var j = 0; j < matrix.ColumnsCount(); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }

                Console.WriteLine();
            }
        }

    }