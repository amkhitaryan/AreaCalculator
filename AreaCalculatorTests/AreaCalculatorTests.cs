using System;
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
            var expectedTriangleArea = 1.984313483298443;
            Figure triangle = new Triangle(2, 2, 3);

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedTriangleArea, actualArea, 0.0001, "Triangle area is calculated wrong");
        }

        [TestMethod]
        public void Calculate_WithValidSides_ReturnsCircleArea()
        {
            // Arrange
            var expectedCircleArea = 78.539816;
            Figure triangle = new Circle(5);

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedCircleArea, actualArea, 0.0001, "Circle area is calculated wrong");
        }

        [TestMethod]
        public void IsRightTriangle_WithValidSides_ShouldReturnTrue()
        {
            // Arrange
            bool expectedResult = true;
            var triangle = new Triangle(5, 3, 4);

            // Act
            var actualResult = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Right Triangle calculated wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CircleCreation_WithNegativeRadius_ShouldTrowArgumentOutOfRange()
        {
            // Arrange

            // Act
            Figure circle = new Circle(-2);

            // Assert is handled by the ExpectedException attribute on the test method.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleCreation_WithNegativeSides_ShouldTrowArgumentOutOfRange()
        {
            // Arrange

            // Act
            Figure triangle = new Triangle(2, -2, 3);

            // Assert is handled by the ExpectedException attribute on the test method.
        }
    }
}
