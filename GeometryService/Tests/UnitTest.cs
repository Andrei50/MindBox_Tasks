using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryService;
using System;

namespace Tests
{
    [TestClass]
    public class GeometryLibraryTests
    {
        [TestMethod]
        public void Circle_CalculateSquare()
        {
            // Arrange
            double radius = 5;
            double expectedSquare = 2 * Math.PI * Math.Pow(radius, 2);
            var circle = new GeometryLibrary.Circle(radius);

            // Act
            double actualSquare = circle.Formula;

            // Assert
            Assert.AreEqual(expectedSquare, actualSquare, 0.01); // Проверяем на равенство с небольшой погрешностью
        }

        [TestMethod]
        public void Triangle_CalculateSquare()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double p = (a + b + c) / 2;
            double expectedSquare = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            var triangle = new GeometryLibrary.Triangle(a, b, c);

            // Act
            double actualSquare = triangle.Formula;

            // Assert
            Assert.AreEqual(expectedSquare, actualSquare, 0.01); // Проверяем на равенство с небольшой погрешностью
        }

        [TestMethod]
        public void Triangle_IsRightTriangle()
        {
            // Arrange
            var triangle = new GeometryLibrary.Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle); // Треугольник с сторонами 3, 4 и 5 должен быть прямоугольным
        }
    }
}
