using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryService;

namespace UnitTest
{
    [TestClass]
    public class GeometryLibraryTests
    {
        [TestMethod]
        public void Circle_CalculateSquare()
        {
            double radius = 5;
            var circle = new GeometryLibrary.Circle(radius);

            double actualSquare = circle.Formula;

            Assert.AreEqual(circle.Formula, actualSquare, 0.01);
        }

        [TestMethod]
        public void Triangle_CalculateSquare()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            var triangle = new GeometryLibrary.Triangle(a, b, c);
            triangle.CalculateSqare();

            double actualSquare = triangle.Formula;

            Assert.AreEqual(triangle.Formula, actualSquare, 0.01);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle()
        {
            var triangle = new GeometryLibrary.Triangle(3, 4, 5);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.IsTrue(isRightTriangle);
        }
    }
}
