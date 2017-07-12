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
                TriangleBuilder mainBuilder = new TriangleBuilder();
                double[] sides = mainReader.ReadDoublesFromConsoleUntilSuccess();
                Triangle mainTriangle = mainBuilder.Create(sides);
                mainTriangle.PrintType();
                Console.ReadKey();
                return (int)MainStatusCodes.ok;
            }
            catch (Exception generalException)
            {
                Console.WriteLine(ERROR_MAIN_MESSAGE);
                Console.WriteLine(generalException.Message);
                Console.ReadKey();
                return (int)MainStatusCodes.exceptionInMain;
            }
        }
    }
}
