using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morskishah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] mqsto = new char[3, 3];

            for (int row = 0; row < 3; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < 3; col++)
                {
                    if (line[col].Length > 0)
                    {
                        mqsto[row, col] = line[col][0];
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (mqsto[i, 0] == mqsto[i, 1] && mqsto[i, 1] == mqsto[i, 2] && mqsto       [i, 0] != '\0')
                {
                    Console.WriteLine("Pobeditel e: " + mqsto[i, 0]);
                    return;
                }

                if (mqsto[0, i] == mqsto[1, i] && mqsto[1, i] == mqsto[2, i] && mqsto[0, i] != '\0')
                {
                    Console.WriteLine("Pobeditel e: " + mqsto[0, i]);
                    return;
                }
            }

            if (mqsto[0, 0] == mqsto[1, 1] && mqsto[1, 1] == mqsto[2, 2] && mqsto[0, 0] != '\0')
            {
                Console.WriteLine("Pobeditel e: " + mqsto[0, 0]);
                return;
            }

            if (mqsto[0, 2] == mqsto[1, 1] && mqsto[1, 1] == mqsto[2, 0] && mqsto   [0, 2] != '\0')
            {
                Console.WriteLine("Pobeditel e: " + mqsto[0, 2]);
                return;
            }

            Console.WriteLine("There is no winner");
        }
    }
}
