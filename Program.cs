using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSet = Console.ReadLine().Split(" ");

            int[,] matrix = new int[Int32.Parse(matrixSet[0]), Int32.Parse(matrixSet[1])];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split(" ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Int32.Parse(input[j]);
                }
            }

            int[,] newMatrix = new int[Int32.Parse(matrixSet[1]), Int32.Parse(matrixSet[0])];

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[newMatrix.GetLength(1) - 1 - j, i];
                }
            }

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}