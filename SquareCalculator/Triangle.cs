using System;
using System.ComponentModel;
using System.Linq;

namespace SquareCalculator
{
    public class Triangle : Shape
    {
        public Triangle(params int[] sides)
        {
            if (sides.Length != 3) throw  new InvalidEnumArgumentException(nameof(Triangle) + " must have 3 sides");
            Sides = sides.ToList();
        }

        public override double CalculateArea()
        {
            double area = 1;
            var p = Sides.Sum() / 2.0;

            foreach (var side in Sides)
            {
                area *= p - side;
            }

            return Math.Sqrt(area * p);

        }

        public bool IsRightTriangle()
        {
            return Sides[0] == (int) Math.Sqrt(Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2)) ||
                   Sides[1] == (int) Math.Sqrt(Math.Pow(Sides[0], 2) + Math.Pow(Sides[2], 2)) ||
                   Sides[2] == (int) Math.Sqrt(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2));
        }
    }
}
