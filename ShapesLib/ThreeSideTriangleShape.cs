
namespace ShapesSquareLib
{
    public class ThreeSideTriangleShape : ITriangle
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public ThreeSideTriangleShape(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetSquare()
        {
            double perimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
        }


        public bool IsRectangular()
        {
            double max = Math.Max(SideA, SideB);
            max = Math.Max(max, SideC);

            double a = Math.Pow(SideA, 2);
            double b = Math.Pow(SideB, 2);
            double c = Math.Pow(SideC, 2);

            double left = (a + b + c);

            return left.EqualsWithError(2 * Math.Pow(max, 2));
        }
    }
}
