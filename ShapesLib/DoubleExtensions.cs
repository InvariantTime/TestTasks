
namespace ShapesSquareLib
{
    public static class DoubleExtensions
    {
        private const double epsilon = 0.000000000001;

        public static bool EqualsWithError(this double left, double right)
        {
            return Math.Abs(left - right) < epsilon;
        }
    }
}
