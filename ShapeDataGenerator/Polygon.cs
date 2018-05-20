using System;

namespace ShapeDataGenerator
{
    public class Polygon : Shape
    {
        public Polygon(int verticesCount, double sideLength) : base(verticesCount, sideLength)
        {
            var radius = sideLength / (2 * Math.Sin(Math.PI / (double)verticesCount));
            Area = 0.5 * verticesCount * radius * radius * Math.Sin(2 * Math.PI / (double)verticesCount);
        }
    }
}
