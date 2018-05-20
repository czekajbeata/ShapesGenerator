using System;

namespace ShapeDataGenerator
{
    public class ConsoleWriter : ISaver
    {
        public void Save(Shape shape)
        {
            Console.WriteLine("Area: " + shape.Area);
            Console.Write("Vertices: ");
            foreach (var vertex in shape.Vertices)
            {
                Console.Write("[" + vertex.X + " ; " + vertex.Y + "] ");
            }
        }
    }
}
