using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] elem = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(elem[col]);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            int[] colMin = new int[cols];
            for (int i = 0; i < colMin.Length; i++)
            {
                colMin[i] = int.MaxValue;
            }
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < colMin[col])
                    {
                        colMin[col] = matrix[row, col];
                    }
                }
            }

            foreach (int min in colMin)
            {
                Console.Write($"{min} ");
            }
        }
    }
}
