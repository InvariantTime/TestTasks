
using ShapesSquareLib;

namespace ShapeSquareLib.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_Is_Rectangular_Test()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            ITriangle triangle = new ThreeSideTriangleShape(a, b, c);

            bool actual = triangle.IsRectangular();

            bool expected = true;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_Is_Not_Rectangular_Test()
        {
            double a = 3;
            double b = 4;
            double c = 5.1;

            ITriangle triangle = new ThreeSideTriangleShape(a, b, c);

            bool actual = triangle.IsRectangular();

            bool expected = false;

            Assert.Equal(expected, actual);
        }
    }
}
