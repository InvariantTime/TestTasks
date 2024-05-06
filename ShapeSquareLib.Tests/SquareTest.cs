using ShapesSquareLib;
using Xunit;

namespace ShapeSquareLib.Tests
{
    public class SquareTest
    {
        private const double epsilon = 0.0000000001;

        [Fact]
        public void Circle_Test()
        {
            double radius = 324;
            IShape circle = new CircleShape(radius);

            double actual = circle.GetSquare();

            double expected = radius * radius * Math.PI;

            Assert.Equal(expected, actual, epsilon);
        }


        [Fact]
        public void ThreeSideTriangle_Test()
        {
            double a = 344;
            double b = 123;
            double c = 311;

            IShape triangle = new ThreeSideTriangleShape(a, b, c);

            double actual = triangle.GetSquare();

            double p = (a + b + c) / 2;

            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.Equal(expected, actual);
        }
    }
}