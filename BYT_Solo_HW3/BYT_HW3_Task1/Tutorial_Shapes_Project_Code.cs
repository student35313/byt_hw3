namespace BYT_HW3_Task1
{
    public interface IShape
    {
        double CalculateArea();
        double CalculateVolume();
    }

    public class Cube(double side) : IShape
    {
        private readonly double _side = side;

        public double CalculateArea()
        {
            return 6 * Math.Pow(_side, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(_side, 3);
        }

    }

    public class Rectangle(double length, double width) : IShape
    {
        private readonly double _length = length;
        private readonly double _width = width;

        public double CalculateArea()
        {
            return _length * _width;
        }

        public double CalculateVolume()
        {
            // For 2D shapes, volume is not applicable.
            // Height of 2D shape is 0, therefore volume is 0
            return 0;
        }
    }

    public class Cylinder(double radius, double height) : IShape
    {
        private readonly double _radius = radius;
        private readonly double _height = height;

        public double CalculateArea()
        {
            return 2 * Math.PI * _radius * (_radius + _height);
        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(_radius, 2) * _height;
        }

    }

    public class Sphere(double radius) : IShape
    {
        private readonly double _radius = radius;

        public double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(_radius, 2);
        }

        public double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }
    }
}