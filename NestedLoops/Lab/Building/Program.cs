﻿using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = levels; i >= 1 ; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == levels)
                    {
                        Console.Write($"L{i}{j} ");

                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
