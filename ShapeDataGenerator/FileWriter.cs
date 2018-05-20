using System.IO;

namespace ShapeDataGenerator
{
    public class FileWriter : ISaver
    {
        public void Save(Shape shape)
        {
            var path = Directory.GetCurrentDirectory() + "PolygonData.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Area: " + shape.Area);
                sw.Write("Vertices: ");
                foreach (var vertex in shape.Vertices)
                {
                    sw.Write("[" + vertex.X + " ; " + vertex.Y + "] ");
                }
            }
        }
    }
}
