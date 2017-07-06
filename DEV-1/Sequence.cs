using System;

namespace DEV_1
{
    class Sequence
    {
        private const int SEQUENCE_START = 0;
        private const int SEQUENCE_END = 100;
        private const int DIVISOR = 3;
        private const string END_MESSAGE = "End of sequence reached";
        public int print()
        {
            try
            {
                for(int i = SEQUENCE_START;i <= SEQUENCE_END; i++)
                {
                    if (i % DIVISOR == 0)
                    {
                        Console.WriteLine(DIVISOR.ToString() + "*" + (i / DIVISOR).ToString());
                    }
                    else
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            catch(Exception)
            {
                return -1;
            }
            Console.WriteLine(END_MESSAGE);
            return 0;
        }

    }
}
