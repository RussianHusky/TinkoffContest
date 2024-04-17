using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> needsChange = new List<KeyValuePair<string, string>>();
            
            var matrixSet = Console.ReadLine().Split(" ");

            int[,] matrix = new int[Int32.Parse(matrixSet[0]), Int32.Parse(matrixSet[0])];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split(" ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Int32.Parse(input[j]);
                }
            }

            if (matrixSet[1] == "R")
            {
                List<string> correct = new List<string>();
                needsChange = new List<KeyValuePair<string, string>>();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != matrix[matrix.GetLength(1) - 1 - j, i])
                        {
                            string firstCord = i + " " + j;
                            string secondCord = (matrix.GetLength(0) - 1 - j) + " " + i;
                            if (!needsChange.Any(x => x.Key == firstCord) && !needsChange.Any(x => x.Key == secondCord)
                                    && !needsChange.Any(x => x.Value == firstCord) && !needsChange.Any(x => x.Value == secondCord))
                            {
                                needsChange.Add(new KeyValuePair<string, string>(firstCord, secondCord));
                            }
                            if (correct.Contains(secondCord))
                            {
                                needsChange.Add(new KeyValuePair<string, string>(firstCord, (i + matrix.GetLength(1) - 1 - j).ToString()));
                            }
                        }
                        else
                        {
                            correct.Add(i + " " + j);
                        }
                    }
                }
            }
            else if (matrixSet[1] == "L")
            {
                List<string> correct = new List<string>();
                needsChange = new List<KeyValuePair<string, string>>();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != matrix[matrix.GetLength(0) - 1 - i, j])
                        {
                            string firstCord = i + " " + j;
                            string secondCord = (matrix.GetLength(0) - 1 - i) + " " + j;
                            if (!needsChange.Any(x => x.Key == firstCord) && !needsChange.Any(x => x.Key == secondCord))
                            {
                                needsChange.Add(new KeyValuePair<string, string>(firstCord, secondCord));
                            }

                            if (correct.Contains(secondCord))
                            {
                                needsChange.Add(new KeyValuePair<string, string>(firstCord, (i + matrix.GetLength(1) - 1 - j).ToString()));
                            }
                        }
                        else
                        {
                            correct.Add(i + " " + j);
                        }
                    }
                }
            }
            Console.WriteLine(needsChange.Count);
            foreach (var VARIABLE in needsChange)
            {
                Console.Write(VARIABLE.Key + " " + VARIABLE.Value + "\n");
            }
        }
    }
}