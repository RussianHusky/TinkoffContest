using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = -1;

            int N = Int32.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split(" ");
            int j = 0;
            int currentMark = 0;
            for (int i = 0; i < N; i++)
            {
                if (input[i] == "2" || input[i] == "3" )
                {
                    j = 0;
                    currentMark = 0;
                    continue;
                }
                else
                {
                    if (input[i] == "5") currentMark++;
                    j++;
                    if (j == 7)
                    {
                        if (currentMark > res) res = currentMark;
                        j = 0;
                    }
                }
            }

            Console.WriteLine(res);
        }
    }
}