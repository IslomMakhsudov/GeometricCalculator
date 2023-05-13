using GeometricCalculator.Interfaces;

namespace GeometricCalculator.Entities
{
    public class Triangle : IShape
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            return double.Parse(area.ToString("F2"));
        }

        public bool IsRightAngle()
        {
            double[] sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
