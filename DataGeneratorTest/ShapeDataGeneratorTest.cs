using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeDataGenerator;

namespace DataGeneratorTest
{
    [TestClass]
    public class ShapeDataGeneratorTest
    {
        [TestMethod]
        public void GetTriangle()
        {
            Shape shape = ShapeFactory.GetShape(3, 1);
            Assert.IsInstanceOfType(shape, typeof(Triangle));
        }

        [TestMethod]
        public void GetSquare()
        {
            Shape shape = ShapeFactory.GetShape(4, 1);
            Assert.IsInstanceOfType(shape, typeof(Square));
        }

        [TestMethod]
        public void GetPolygon()
        {
            Shape shape = ShapeFactory.GetShape(7, 1);
            Assert.IsInstanceOfType(shape, typeof(Polygon));
        }

        [TestMethod]
        public void GetSquareData()
        {
            Shape shape = ShapeFactory.GetShape(4, 2);
            Assert.AreEqual(4, shape.Area);

            Assert.AreEqual(2, GetDistance(shape.Vertices[0], shape.Vertices[1]), 0.001f);
            Assert.AreEqual(2, GetDistance(shape.Vertices[1], shape.Vertices[2]), 0.001f);
            Assert.AreEqual(2, GetDistance(shape.Vertices[2], shape.Vertices[3]), 0.001f);
            Assert.AreEqual(2, GetDistance(shape.Vertices[3], shape.Vertices[0]), 0.001f);
        }

        [TestMethod]
        public void GetHexagonData()
        {
            Shape shape = ShapeFactory.GetShape(6, 3);
            Assert.AreEqual(23.382, shape.Area, 0.001f);

            Assert.AreEqual(3, GetDistance(shape.Vertices[0], shape.Vertices[1]), 0.001f);
            Assert.AreEqual(3, GetDistance(shape.Vertices[1], shape.Vertices[2]), 0.001f);
            Assert.AreEqual(3, GetDistance(shape.Vertices[2], shape.Vertices[3]), 0.001f);
            Assert.AreEqual(3, GetDistance(shape.Vertices[3], shape.Vertices[4]), 0.001f);
            Assert.AreEqual(3, GetDistance(shape.Vertices[4], shape.Vertices[5]), 0.001f);
            Assert.AreEqual(3, GetDistance(shape.Vertices[5], shape.Vertices[0]), 0.001f);
        }

        public static double GetDistance(Vector2 first, Vector2 second)
        {
           return Math.Sqrt((second.X - first.X) * (second.X - first.X) + (second.Y - first.Y) * (second.Y - first.Y));
        }
    }
}
