using System;

namespace _2_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxRandomNamber = 100;
            int minRandomNamber = 10;
            Random random = new Random();
            int[,] matrix = new int[10,10];
            int maxNamberInMatrix = int.MinValue;
            int namberToReplace = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = random.Next(minRandomNamber, maxRandomNamber);
                }
            }

            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] > maxNamberInMatrix)
                    {
                        maxNamberInMatrix = matrix[i,j];
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxNamberInMatrix)
                    {
                        matrix[i,j] = namberToReplace;
                    }
                }
            }

            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Максимальное число в матрице: " + maxNamberInMatrix);

            Console.SetCursorPosition(0, 13);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
