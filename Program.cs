using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure>
            {
                new Circle(10, 10, 100),
                new Square(1,1, 5,5, 10,10, 100, 100),
                new Rectangle(100, 100, 200, 200, 300, 300, 500, 500),
                new Triangle(3,3, 5,5, 7,7),
                new Circle(20, 20, 10),
                new Rectangle(1, 1, 5, 5, 20, 20, 80, 80)
            };

            foreach(var item in figures)
            {
                item.Draw();
            }

            Console.ReadKey();
        }
    }
}
