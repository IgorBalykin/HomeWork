using System;


namespace DEV_1
{
    class CustomSequenceOutputter
    {
        private const string ERROR_MAIN_MESSAGE = "Looks like something really bad happened, halting with error code";
        static int Main(string[] args)
        {
            try
            {
                Sequence seq = new Sequence();
                seq.print();
                Console.ReadKey();
            }
            catch(Exception)
            {
                Console.WriteLine(ERROR_MAIN_MESSAGE);
                return -1;
            }
            return 0;
        }
    }
}
