using System;

namespace DEV_3
{
    class FibNumConsoleReader
    {
        private const int MAX_ATTEMPTS = int.MaxValue;
        private const string EXIT_KEY = "q";
        private const string INPUT_QUERY = "Enter number or q to quit from number input";
        private const string MSG_ERROR = "Error occured:";
        private const string SECOND_QUERY = "Please, repeat attempt or enter q to quit";
        private FibNumber FibNum = new FibNumber();
        public void ReadNumber()
        {
            Console.WriteLine(INPUT_QUERY);
            for (int i = 0; i < MAX_ATTEMPTS; i++)
            {
                string rawNumber = Console.ReadLine();
                if (rawNumber == EXIT_KEY)
                {
                    break;
                }

                NumberValidStatus numberValidStat = FibNum.Validator.Validate(rawNumber);
                if (numberValidStat == NumberValidStatus.ok)
                {
                    FibNum.Number = int.Parse(rawNumber); //side effect of setter - output on number type
                }
                else
                {
                    Console.WriteLine(MSG_ERROR);
                    FibNum.Validator.ShowValidationStatus(numberValidStat);
                }
                Console.WriteLine(SECOND_QUERY);
            }
        }
    }
}
