using BYT_HW3_Task1;

namespace BYT_Solo_HW3
{
    public class Tests
    {
        [Test]
        public void TestSphereCalculateArea()
        {
            IShape sphere = new Sphere(5);
            double area = sphere.CalculateArea();
            Assert.That(area, Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            IShape sphere = new Sphere(5);
            double volume = sphere.CalculateVolume();
            Assert.That(volume, Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateArea()
        {
            IShape cube = new Cube(4);
            double area = cube.CalculateArea();
            Assert.That(area, Is.EqualTo(96));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            IShape cube = new Cube(4);
            double volume = cube.CalculateVolume();
            Assert.That(volume, Is.EqualTo(64));
        }
        
        [Test]
        public void TestCubeCalculations_WhenSideIsZero_ShouldReturnZero()
        {
            IShape zeroCube = new Cube(0);
            Assert.That(zeroCube.CalculateArea(), Is.EqualTo(0));
            Assert.That(zeroCube.CalculateVolume(), Is.EqualTo(0));
        }
        
        [Test]
        public void TestRectangleCalculateArea()
        {
            IShape rectangle = new Rectangle(4, 8);
            double area = rectangle.CalculateArea();
            Assert.That(area, Is.EqualTo(32));
        }

        [Test]
        public void TestRectangleCalculateVolume_ShouldAlwaysBeZero()
        {
            IShape rectangle = new Rectangle(4, 8);
            double volume = rectangle.CalculateVolume();
            Assert.That(volume, Is.EqualTo(0));
        }
        
        [Test]
        public void TestCylinderCalculateArea()
        {
            IShape cylinder = new Cylinder(3, 7);
            double area = cylinder.CalculateArea();
            Assert.That(area, Is.EqualTo(188.495).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            IShape cylinder = new Cylinder(3, 7);
            double volume = cylinder.CalculateVolume();
            Assert.That(volume, Is.EqualTo(197.920).Within(0.001));
        }
    }
}