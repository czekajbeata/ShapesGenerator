using System;

namespace ShapeDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Please enter correct arguments [number of vertices, side length, saving method: console/file].");
                return;
            }

            var verticesCountArg = int.Parse(args[0]);
            var sideLengthArg = double.Parse(args[1]);
            var saveTypeArg = args[2];

            try
            {
                Shape shape = ShapeFactory.GetShape(verticesCountArg, sideLengthArg);

                ISaver dataSaver;
                if (saveTypeArg == "console")
                    dataSaver = new ConsoleWriter();
                else if (saveTypeArg == "file")
                    dataSaver = new FileWriter();
                else throw new ArgumentException("Non existing saving method was chosen. Please use \"console\" or \"file\".");

                dataSaver.Save(shape);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
