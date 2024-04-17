using System;

namespace ConsoleApp2
{
    class Task5
    {
        static void Main(string[] args)
        {
            int res = 0;
            int N = int.Parse(Console.ReadLine());
            string currentLevel = Console.ReadLine();
            int currentPos = 1;
            string nextLevel = Console.ReadLine();
            string after = "";
            for (int i = 0; i < N - 2; i++)
            {
                after = Console.ReadLine();
                switch (currentPos)
                {
                    case 0:
                        if (nextLevel[0] == 'C')
                        {
                            if (after[0] != 'W' || after[1] != 'W')
                            {
                                currentPos = 0;
                                res++;
                                break;
                            }
                        }

                        if (nextLevel[1] == 'C')
                        {
                            if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 1;
                                res++;
                                break;
                            }
                        }

                        if (nextLevel[0] == '.')
                        {
                            if (after[0] != 'W' || after[1] != 'W')
                            {
                                currentPos = 0;
                                break;
                            }
                        }

                        if (nextLevel[1] == '.')
                        {
                            if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 1;
                                break;
                            }
                        }

                        break;
                    case 1:
                        if (nextLevel[0] == 'C')
                        {
                            if (after[0] != 'W' || after[1] != 'W')
                            {
                                currentPos = 0;
                                res++;
                                break;
                            }
                        }

                        if (nextLevel[1] == 'C')
                        {
                            if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 1;
                                res++;
                                break;
                            }
                        }

                        if (nextLevel[2] == 'C')
                        {
                            if (after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 2;
                                res++;
                                break;
                            }
                        }

                        if (nextLevel[0] == '.')
                        {
                            if (after[0] != 'W' || after[1] != 'W')
                            {
                                currentPos = 0;
                                break;
                            }
                        }

                        if (nextLevel[1] == '.')
                        {
                            if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 1;
                                break;
                            }
                        }

                        if (nextLevel[2] == '.')
                        {
                            if (after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 2;
                                break;
                            }
                        }

                        break;
                    case 2:
                        if (nextLevel[1] == 'C')
                        {
                            if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 1;
                                res++;
                                break;
                            }
                        }

                        if (nextLevel[2] == 'C')
                        {
                            if (after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 2;
                                res++;
                                break;
                            }
                        }

                        if (nextLevel[1] == '.')
                        {
                            if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 1;
                                break;
                            }
                        }

                        if (nextLevel[2] == '.')
                        {
                            if (after[1] != 'W' || after[2] != 'W')
                            {
                                currentPos = 2;
                                break;
                            }
                        }

                        break;
                }

                currentLevel = nextLevel;
                nextLevel = after;
            }

            switch (currentPos)
            {
                case 0:
                    if (nextLevel[0] == 'C')
                    {
                        if (after[0] != 'W' || after[1] != 'W')
                        {
                            currentPos = 0;
                            res++;
                            break;
                        }
                    }

                    if (nextLevel[1] == 'C')
                    {
                        if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 1;
                            res++;
                            break;
                        }
                    }

                    if (nextLevel[0] == '.')
                    {
                        if (after[0] != 'W' || after[1] != 'W')
                        {
                            currentPos = 0;
                            break;
                        }
                    }

                    if (nextLevel[1] == '.')
                    {
                        if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 1;
                            break;
                        }
                    }

                    break;
                case 1:
                    if (nextLevel[0] == 'C')
                    {
                        if (after[0] != 'W' || after[1] != 'W')
                        {
                            currentPos = 0;
                            res++;
                            break;
                        }
                    }

                    if (nextLevel[1] == 'C')
                    {
                        if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 1;
                            res++;
                            break;
                        }
                    }

                    if (nextLevel[2] == 'C')
                    {
                        if (after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 2;
                            res++;
                            break;
                        }
                    }

                    if (nextLevel[0] == '.')
                    {
                        if (after[0] != 'W' || after[1] != 'W')
                        {
                            currentPos = 0;
                            break;
                        }
                    }

                    if (nextLevel[1] == '.')
                    {
                        if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 1;
                            break;
                        }
                    }

                    if (nextLevel[2] == '.')
                    {
                        if (after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 2;
                            break;
                        }
                    }

                    break;
                case 2:
                    if (nextLevel[1] == 'C')
                    {
                        if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 1;
                            res++;
                            break;
                        }
                    }

                    if (nextLevel[2] == 'C')
                    {
                        if (after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 2;
                            res++;
                            break;
                        }
                    }

                    if (nextLevel[1] == '.')
                    {
                        if (after[0] != 'W' || after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 1;
                            break;
                        }
                    }

                    if (nextLevel[2] == '.')
                    {
                        if (after[1] != 'W' || after[2] != 'W')
                        {
                            currentPos = 2;
                            break;
                        }
                    }

                    break;
            }
            
            Console.WriteLine(res);
        }
    }
}
