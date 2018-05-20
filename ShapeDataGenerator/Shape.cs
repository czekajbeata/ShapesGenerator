using System;
using System.Numerics;

namespace ShapeDataGenerator
{
    public abstract class Shape
    {
        public double Area { get; protected set; }
        public Vector2[] Vertices { get; }

        protected Shape(int verticesCount, double sideLength)
        {
            var angleStep = 360 / (double)verticesCount;
            var radius = CalcRadius(verticesCount, sideLength);

            Vertices = new Vector2[verticesCount];

            for (int i = 0; i < verticesCount; i++)
            {
                var angle = angleStep * i;
                var angleInRadian = ToRadians(angle);

                var cos = Math.Cos(angleInRadian);
                var sin = Math.Sin(angleInRadian);

                Vertices[i].X = (float)(cos * radius);
                Vertices[i].Y = (float)(sin * radius);
            }

            var firstVertex = Vertices[0];
            for (int i = 0; i < verticesCount; i++)
            {
                Vertices[i] -= firstVertex;
            }
        }

        private static double CalcRadius(int verticesCount, double sideLength)
        {
            var radiusAngle = ToRadians(180 / (double)verticesCount);
            return sideLength / (2 * Math.Sin(radiusAngle)); ;
        }

        private static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
    }
}
