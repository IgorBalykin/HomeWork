using System;

namespace DEV_1
{
    enum CustomSequenceStatusCodes
    {
        Ok = 0,
        ExceptionInMain = -1,
        GeneralException = -2
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
                return (int) CustomSequenceStatusCodes.ExceptionInMain;
            }
            return (int) CustomSequenceStatusCodes.Ok;
        }
    }
}
