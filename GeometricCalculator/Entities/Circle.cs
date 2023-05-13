using GeometricCalculator.Interfaces;

namespace GeometricCalculator.Entities
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            double area = Math.PI * Radius * Radius;
            return double.Parse(area.ToString("F2"));
        }
    }
}
