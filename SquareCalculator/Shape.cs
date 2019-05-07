using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareCalculator
{
    public abstract class Shape
    {
        public List<int> Sides
        {
            get => _sides;
            set
            {
                if (value.Any(x => x <= 0))
                    throw new ArgumentOutOfRangeException("Sides of a shape must be positive numbers");
                _sides = value;
            }
        }

        private List<int> _sides;

        public abstract double CalculateArea();
    }
}
