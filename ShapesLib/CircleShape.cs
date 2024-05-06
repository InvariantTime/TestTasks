
namespace ShapesSquareLib
{
    public class CircleShape : IShape
    {
        public double Radius { get; }

        public CircleShape(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius cannot be less than 0");

            Radius = radius;
        }


        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
