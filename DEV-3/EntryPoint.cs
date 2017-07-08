using System;

namespace DEV_3
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
                FibNumConsoleReader mainReader = new FibNumConsoleReader();
                mainReader.ReadNumber();
            }
            catch (Exception)
            {
                Console.WriteLine(ERROR_MAIN_MESSAGE);
                return (int)MainStatusCodes.exceptionInMain;
            }
            return (int)MainStatusCodes.ok;
        }
    }
}
