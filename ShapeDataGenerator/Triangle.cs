using System;

namespace ShapeDataGenerator
{
    public class Triangle : Shape
    {
        public Triangle(int verticesCount, double sideLength) : base(verticesCount, sideLength)
        {
            Area = (sideLength * sideLength * Math.Sqrt(3)) / 4.0;
        }
    }
}
