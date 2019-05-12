using System;
using AreaCalculator;

namespace AreaCalculatorUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usage example:\n");

            Figure triangle = new Triangle(2, 2, 3);
            Console.WriteLine("Triangle1 is " + (((Triangle) triangle).IsRightTriangle() ? "" : "not ") + "a right triangle");
            Console.WriteLine("Triangle1 area = " + triangle.CalculateArea());

            Figure rightTriangle = new Triangle(5, 3, 4);
            Console.WriteLine("Triangle2 is " + (((Triangle)rightTriangle).IsRightTriangle() ? "" : "not ") + "a right triangle");
            Console.WriteLine("Triangle 2 area = " + rightTriangle.CalculateArea());

            Figure circle;
            try
            {
                circle = new Circle(-5);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                circle = new Circle(5);
            }

            Console.WriteLine("Circle area = " + circle.CalculateArea());

        }
    }
}
