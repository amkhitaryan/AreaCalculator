using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace AreaCalculatorTests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void Calculate_WithValidSides_ReturnsTriangleArea()
        {
            // Arrange
            int[] sides = {2, 2, 3};
            var expectedTriangleArea = 1.984313483298443;
            Shape triangle = new Triangle(sides);

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedTriangleArea, actualArea, 0.0001, "Triangle area is calculated wrong");
        }

        [TestMethod]
        public void Calculate_WithValidSides_ReturnsCircleArea()
        {
            // Arrange
            int[] sides = { 5};
            var expectedCircleArea = 78.539816;
            Shape triangle = new Circle(sides);

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedCircleArea, actualArea, 0.0001, "Circle area is calculated wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void TriangleCreation_WithMoreSides_ShouldTrowInvalidEnumArgument()
        {
            // Arrange
            int[] sides = {2, 2, 3, 5};

            // Act
            Shape triangle = new Triangle(sides);

            // Assert is handled by the ExpectedException attribute on the test method.
        }

        [TestMethod]
        public void TriangleCreation_WithLessSides_ShouldTrowInvalidEnumArgument()
        {
            // Arrange
            int[] sides = { 2, 2 };

            // Act
            try
            {
                Shape triangle = new Triangle(sides);
            }
            catch (InvalidEnumArgumentException e)
            {
                // Assert
                StringAssert.Contains(e.Message, nameof(Triangle) + " must have 3 sides");
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void IsRightTriangle_WithValidSides_ShouldReturnTrue()
        {
            // Arrange
            int[] sides = {5, 3, 4};
            bool expectedResult = true;
            var triangle = new Triangle(sides);

            // Act
            var actualResult = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Right Triangle calculated wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void CircleCreation_WithMoreSides_ShouldTrowInvalidEnumArgument()
        {
            // Arrange
            int[] sides = { 2, 2 };

            // Act
            Shape circle = new Circle(sides);

            // Assert is handled by the ExpectedException attribute on the test method.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShapeCreation_WithNegativeSides_ShouldTrowArgumentOutOfRange()
        {
            // Arrange
            int[] sides = { -2, 2, 2 };

            // Act
            Shape triangle = new Triangle(sides);

            // Assert is handled by the ExpectedException attribute on the test method.
        }
    }
}
