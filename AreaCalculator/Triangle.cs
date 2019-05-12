using System;

namespace AreaCalculator
{
    public class Triangle : Figure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
            Validate();
        }

        public double CalculateArea()
        {
            var p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private void Validate()
        {
            if (A <= 0 || B <= 0 || C <= 0)
                throw new ArgumentOutOfRangeException(nameof(Triangle) + " sides of a triangle must be greater than 0");
        }

        public bool IsRightTriangle()
        {
            return A == (int) Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)) ||
                   B == (int) Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2)) ||
                   C == (int) Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
    }
}