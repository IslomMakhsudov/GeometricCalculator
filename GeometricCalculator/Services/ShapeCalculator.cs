using GeometricCalculator.Interfaces;

namespace GeometricCalculator.Services
{
    public static class ShapeCalculator
    {
        public static double GetArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
