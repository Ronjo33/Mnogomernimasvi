using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srednoaritmeti4noPoredove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int k = 0; k < rows; k++)
            {
                for (int a = 0; a < cols; a++)
                {
                    matrix[k, a] = int.Parse(Console.ReadLine());
                }
            }

            double[] lineAvg = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                double sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                lineAvg[i] = sum / cols;
                Console.WriteLine($"- {lineAvg[i]:F2}");
            }
        }
    }
}
