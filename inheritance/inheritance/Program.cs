using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        protected string color;
        protected bool filled;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        public string GetColor()
        {
            return color;
        }

        public bool GetFilled()
        {
            return filled;
        }

        public abstract double Area();
    }

    class Rectangle : Shape
    {
        double width;
        double height;

        public Rectangle()
        {
        }

        public Rectangle(string color, bool filled, double width, double height)
        {
            this.color = color;
            this.filled = filled;
            this.width = width;
            this.height = height;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }

    class Circle : Shape
    {
        double radius;

        public Circle()
        {
        }

        public Circle(string color, bool filled, double radius)
        {
            this.color = color;
            this.filled = filled;
            this.radius = radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    class Triangle : Shape
    {
        double side1;
        double side2;
        double side3;

        public Triangle(string color, bool filled, double side1, double side2, double side3) : base(color, filled)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Area()
        {
            // Heron's formula for the area of a triangle
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Blue", false, 2.0);

            Console.WriteLine("Circle area = {0}", circle.Area());
            Console.WriteLine("Circle color = {0}", circle.GetColor());
            Console.WriteLine("Circle filled = {0}", circle.GetFilled());

            Rectangle rectangle = new Rectangle();

            rectangle.SetWidth(5);
            rectangle.SetHeight(6);
            rectangle.SetColor("Red");
            rectangle.SetFilled(true);

            Console.WriteLine("Rectangle area = {0}", rectangle.Area());
            Console.WriteLine("Rectangle color = {0}", rectangle.GetColor());
            Console.WriteLine("Rectangle filled = {0}", rectangle.GetFilled());

            Triangle triangle = new Triangle("Green", true, 3.0, 4.0, 5.0);
            Console.WriteLine("Triangle area = {0}", triangle.Area());
            Console.WriteLine("Triangle color = {0}", triangle.GetColor());
            Console.WriteLine("Triangle filled = {0}", triangle.GetFilled());

            Console.ReadKey();
        }
    }
}
