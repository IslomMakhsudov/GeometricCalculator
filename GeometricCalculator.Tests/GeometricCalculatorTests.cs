using GeometricCalculator.Services;

namespace GeometricCalculator.Tests
{
    [TestFixture]
    public class GeometricCalculatorTests
    {
        [Test]
        public void Circle_GetArea_ReturnsCorrectValue()
        {
            // Arrange
            var circle = new Circle(2.5);
            double expectedArea = Math.PI * 2.5 * 2.5;
            expectedArea = double.Parse(expectedArea.ToString("F2"));

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.That(expectedArea, Is.EqualTo(actualArea));
        }

        [Test]
        public void Triangle_GetArea_ReturnsCorrectValue()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 5.0);
            double expectedArea = 6.0;
            expectedArea = double.Parse(expectedArea.ToString("F2"));

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.That(expectedArea, Is.EqualTo(actualArea));
        }

        [Test]
        public void Triangle_IsRightAngle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 5.0);

            // Act
            bool isRightAngle = triangle.IsRightAngle();

            // Assert
            Assert.That(isRightAngle);
        }

        [Test]
        public void Triangle_IsRightAngle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(2.0, 3.0, 4.0);

            // Act
            bool isRightAngle = triangle.IsRightAngle();

            // Assert
            Assert.That(!isRightAngle);
        }

        [Test]
        public void ShapeCalculator_GetArea_ReturnsCorrectValue()
        {
            // Arrange
            var circle = new Circle(2.5);
            var triangle = new Triangle(3.0, 4.0, 5.0);

            double expectedCircleArea = Math.PI * 2.5 * 2.5;
            expectedCircleArea = double.Parse(expectedCircleArea.ToString("F2"));

            double expectedTriangleArea = 6.0;
            expectedTriangleArea = double.Parse(expectedTriangleArea.ToString("F2"));

            // Act
            var actualCircleArea = ShapeCalculator.GetArea(circle);
            var actualTriangleArea = ShapeCalculator.GetArea(triangle);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(actualCircleArea, Is.EqualTo(expectedCircleArea));
                Assert.That(actualTriangleArea, Is.EqualTo(expectedTriangleArea));
            });
        }
    }
}
