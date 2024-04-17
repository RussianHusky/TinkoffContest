using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Task3
    {
        class Folder
        {
            public Folder parent = null;
            public List<Folder> children = new List<Folder>();
            public string name;

            public Folder(string name)
            {
                this.name = name;
            }
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string pattern = @"([^/]+)";
            Regex rg = new Regex(pattern);
            Folder root = null;
            for (int i = 0; i < N; i++)
            {
                
                MatchCollection folders = rg.Matches(Console.ReadLine());
                if (i == 0)
                {
                    root = new Folder(folders[0].Value);
                }
                
                Folder previousFolder = root;
                
                for (int j = 1; j < folders.Count; j++)
                {
                    if (previousFolder.children.Count == 0)
                    {
                        Folder newFolder = new Folder(folders[j].Value);
                        newFolder.parent = previousFolder;
                        previousFolder.children.Add(newFolder);
                        previousFolder = newFolder;
                    }
                    else
                    {
                        bool found = false;
                        foreach (Folder VARIABLE in previousFolder.children)
                        {
                            if (VARIABLE.name == folders[j].Value)
                            {
                                previousFolder = VARIABLE;
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Folder newFolder = new Folder(folders[j].Value);
                            newFolder.parent = previousFolder;
                            previousFolder.children.Add(newFolder);
                            previousFolder = newFolder;
                        }
                    }
                }
            }

            OutputTree(root, 0);
        }

        static void OutputTree(Folder root, int spaces)
        {
            
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }

            Console.Write(root.name + "\n");
            foreach (var VARIABLE in root.children)
            {
                OutputTree(VARIABLE, spaces + 2);
            }
        }
    }
    
}
