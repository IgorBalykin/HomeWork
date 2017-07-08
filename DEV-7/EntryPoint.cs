using System;

namespace DEV_7
{
    class EntryPoint
    {
        enum MainStatusCodes
        {
            ok = 0,
            exceptionInMain = -1,
            generalException = -2
        }
        private const string ERROR_MAIN_MESSAGE = "Looks like something really bad happened, halting with error code";
        static int Main(string[] args)
        {
            try
            {
                ConsoleReader mainReader = new ConsoleReader();
                TriangleTypeDeterminator mainDeterminator = new TriangleTypeDeterminator();
                double[] sides = mainReader.ReadDoublesFromConsoleUntilSuccess();
                Triangle mainTriangle = new Triangle(sides);
                mainDeterminator.DetermineAndShowType(mainTriangle);
                Console.ReadKey();
                return (int)MainStatusCodes.ok;
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR_MAIN_MESSAGE);
                return (int)MainStatusCodes.exceptionInMain;
            }
        }
    }
}
