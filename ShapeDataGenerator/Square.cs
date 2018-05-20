namespace ShapeDataGenerator
{
    public class Square : Shape
    {
        public Square(int verticesCount, double sideLength) : base(verticesCount, sideLength)
        {
            Area = sideLength * sideLength;
        }
    }
}
