namespace SurfaceCalculator
{
    public class Rectangle
    {
        private readonly double length;
        private readonly double width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateSurface()
        {
            return this.length * this.width;
        }
    }
}