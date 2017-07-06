using System;

namespace DEV_1
{
    enum CustomSequenceStatusCodes
    {
        ok = 0,
        exceptionInMain = -1
    }
    class CustomSequenceOutputter
    {
        private const string ERROR_MAIN_MESSAGE = "Looks like something really bad happened, halting with error code";
        static int Main(string[] args)
        {
            try
            {
                Sequence mainProgramSequence = new Sequence();
                mainProgramSequence.Print();
                Console.ReadKey();
            }
            catch(Exception)
            {
                Console.WriteLine(ERROR_MAIN_MESSAGE);
                return (int) CustomSequenceStatusCodes.exceptionInMain;
            }
            return (int) CustomSequenceStatusCodes.ok;
        }
    }
}
