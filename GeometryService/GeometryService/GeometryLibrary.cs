using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GeometryService
{
    public class GeometryLibrary
    {
        public class Figure
        {
            public double Formula { get; set; }
            public void CalculateSqare()
            {
                Console.WriteLine($"Площадь фигуры равна: {Formula}");
            }
        }

        public class Circle : Figure
        {
            public double r {  get; set; }
            public Circle(double _r)
            {
                r = _r;
                this.Formula = 2 * Math.PI * Math.Pow(r, 2);
            }
        }

        public class Triangle: Figure
        {
            public double a {  get; set; }
            public double b { get; set; }
            public double c { get; set; }
            public Triangle (double _a, double _b, double _c)
            {
                a = _a;
                b = _b;
                c = _c;
                double p = (a + b + c) / 2;
                this.Formula = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

            public bool IsRightTriangle()
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                    Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) ||
                    Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                {
                    Console.WriteLine("Треугольник является прямоугольным");
                    return true;
                }
                else
                {
                    Console.WriteLine("Треугольник не является прямоугольным");
                    return false;
                }
            }
        }
    }
}
