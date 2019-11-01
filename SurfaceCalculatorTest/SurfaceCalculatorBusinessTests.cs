using NFluent;
using NUnit.Framework;
using SurfaceCalculator;

namespace SurfaceCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_return_surface_When_form_is_rectangle()
        {
            Rectangle form = new Rectangle(50, 20);
            double actual = form.CalculateSurface();
            Check.That(actual).IsEqualTo(1000);
        }

        [Test]
        public void Should_return_surface_When_form_is_square()
        {
            Square form = new Square(20, 20);
            double actual = form.CalculateSurface();
            Check.That(actual).IsEqualTo(400);
        }
    }
}   