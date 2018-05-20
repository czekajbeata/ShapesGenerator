using System;

namespace ShapeDataGenerator
{
    public class ShapeFactory
    {
        public static Shape GetShape(int verticesCount, double sideLength)
        {
            if (verticesCount < 3) 
                throw new ArgumentException("Not enough vertices to make any shape.", nameof(verticesCount));

            if (sideLength <= 0)
                throw new ArgumentException("Side length must be positive.", nameof(sideLength));

            switch (verticesCount)
            {
                case 3:
                    return new Triangle(verticesCount, sideLength);
                case 4:
                    return new Square(verticesCount, sideLength);
                default:
                    return new Polygon(verticesCount, sideLength);
            }
        }
    }
}
