using System;
using System.ComponentModel;
using System.Linq;

namespace AreaCalculator
{
    public class Circle : Shape
    {
        public Circle(params int[] radius)
        {
            if (radius.Length == 1)
            {
                Sides = radius.ToList();
            }
            else
            {
                throw new InvalidEnumArgumentException(nameof(Circle) + " radius is missing or invalid");
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Sides.FirstOrDefault(), 2);
        }
    }
}
