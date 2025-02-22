﻿using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0.0;
            //(square, rectangle, circle или triangle).
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (a * height) / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
