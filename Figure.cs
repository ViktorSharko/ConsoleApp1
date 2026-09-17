using System;

namespace ConsoleApp1
{
    internal class Figure
    {
        public virtual void Draw()
        {
            throw new NotImplementedException();
        }
    }

    internal class Circle : Figure
    {  
        public Circle(double x, double y, double radius) 
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("A circle is being drawn");
        }

        // зачем double? может, достаточно и int-ов? ну да ладно
        protected double X;
        protected double Y;
        protected double Radius;
    }

    internal class Square : Figure
    {
        // здесь очень много букофф - убрать и сделать (а лучше везе) Point, ну да пока ладно.
        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            X1 = x1;
            Y1 = y1;

            X1 = x2;
            Y1 = y2;

            X1 = x3;
            Y1 = y3;

            X1 = x4;
            Y1 = y4;

        }

        public override void Draw()
        {
            Console.WriteLine("A square is being drawn");
        }

        protected double X1;
        protected double Y1;
        protected double X2;
        protected double Y2;
        protected double X3;
        protected double Y3;
        protected double X4;
        protected double Y4;
    }

    internal class Rectangle : Square 
    {
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("A rectangle is being drawn");
        }
    }

    internal class Triangle : Figure 
    {
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            Y1 = y1;

            X1 = x2;
            Y1 = y2;

            X1 = x3;
            Y1 = y3;
        }

        public override void Draw()
        {
            Console.WriteLine("A triangle is being drawn");
        }

        protected double X1;
        protected double Y1;
        protected double X2;
        protected double Y2;
        protected double X3;
        protected double Y3;
    }
}
