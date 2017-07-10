using System;

namespace DEV_1
{
    class Sequence
    {
        enum NumberStates
        {
            DividesByNone = 0,
            DividesByFirst = 1,
            DividesBySecond = 2,
            DividesByBoth = 3
        }
        private const int SEQUENCE_START = 0;
        private const int SEQUENCE_END = 100;
        private const int DIVISOR1 = 3;
        private const int DIVISOR2 = 5;
        private const string DIVISOR1_MSG = "Tutti";
        private const string DIVISOR2_MSG = "Frutti";
        private const string DIVIVISOR1_AND_2_MSG = "Tutti-Frutti";
        private const string DIVISOR_UNKNOWN_MSG = "Warning, wrong argument";
        private const string END_MESSAGE = "End of sequence reached";
        private NumberStates CheckNumberForDivisors(int number)
        {
            bool dividesByFirst = (number % DIVISOR1 == 0);
            bool dividesBySecond = (number % DIVISOR2 == 0);
            if (dividesByFirst && dividesBySecond)
            {
                return NumberStates.DividesByBoth;
            }
            else if (dividesByFirst)
            {
                return NumberStates.DividesByFirst;
            }
            else if (dividesBySecond)
            {
                return NumberStates.DividesBySecond;
            }
            else
            {
                return NumberStates.DividesByNone;
            }
        }
        private void PrintNumberOrMessage(int number)
        {
            var numberState = CheckNumberForDivisors(number);
            switch (numberState)
            {
                case NumberStates.DividesByNone:
                    Console.WriteLine(number.ToString());
                    break;
                case NumberStates.DividesByFirst:
                    Console.WriteLine(DIVISOR1_MSG);
                    break;
                case NumberStates.DividesBySecond:
                    Console.WriteLine(DIVISOR2_MSG);
                    break;
                case NumberStates.DividesByBoth:
                    Console.WriteLine(DIVIVISOR1_AND_2_MSG);
                    break;
                default:
                    Console.WriteLine(DIVISOR_UNKNOWN_MSG);
                    break;

            }
        }
        public int Print()
        {
            try
            {
                for (int i = SEQUENCE_START; i <= SEQUENCE_END; i++)
                {
                    PrintNumberOrMessage(i);
                }
            }
            catch (Exception)
            {
                return (int)CustomSequenceStatusCodes.GeneralException;
            }
            Console.WriteLine(END_MESSAGE);
            return (int)CustomSequenceStatusCodes.Ok;
        }

    }
}
