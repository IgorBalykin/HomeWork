using System;

namespace DEV_7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ConsoleReader mainReader = new ConsoleReader();
            TriangleTypeDeterminator mainDeterminator = new TriangleTypeDeterminator();
            double[] sides = mainReader.ReadDoublesFromConsoleUntilSuccess();
            Triangle mainTriangle = new Triangle(sides);
            mainDeterminator.DetermineAndShowType(mainTriangle);
            Console.ReadKey();
        }
    }
}
