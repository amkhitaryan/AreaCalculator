using System;
using SquareCalculator;

namespace SquareCalculatorUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imitating user to test functionality.\n");

            Shape triangle = new Triangle(2, 2, 3);
            Console.WriteLine("Triangle1 is right triangle: " + ((Triangle) triangle).IsRightTriangle());
            Console.WriteLine("Triangle1 area = " + triangle.CalculateArea());

            Shape rightTriangle = new Triangle(5, 3, 4);
            Console.WriteLine("Triangle2 is right triangle: " + ((Triangle) rightTriangle).IsRightTriangle());
            Console.WriteLine("Triangle 2 area = " + rightTriangle.CalculateArea());

            Shape circle;
            try
            {
                circle = new Circle(-5);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                circle = new Circle(5);
            }

            Console.WriteLine("Circle area: " + circle.CalculateArea());

        }
    }
}
