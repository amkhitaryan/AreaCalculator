using System;

namespace AreaCalculator
{
    public class Circle : Figure
    {
        public int R { get; set; }

        public Circle(int radius)
        {
            R = radius;
            Validate();
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        private void Validate()
        {
            if (R <= 0) throw new ArgumentOutOfRangeException(nameof(Circle) + " radius must be greater than 0");
        }
    }
}
