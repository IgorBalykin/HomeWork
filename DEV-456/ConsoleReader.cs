using System;

namespace DEV_456
{
    class ConsoleReader
    {
        private readonly char[] DELIMETERS = new char[] { ' ', ';' };
        private const int MAX_ATTEMPTS = int.MaxValue;
        private const string INPUT_QUERY = "Please, enter double sequnce or q to exit input routine";
        private const string EXIT_KEY = "q";
        private const string MSG_INPUT_UNPARSABLE = "Input is unparsable, probably wrong delimeter or value";
        public string GetRawData()
        {
            return Console.ReadLine();
        }
        public string[] SplitRawData(string rawInput)
        {
            return rawInput.Split(DELIMETERS);
        }
        public bool TryParseDataDouble(string[] splittedRaw, out double[] parsedDoubles)
        {
            parsedDoubles = new double[splittedRaw.Length];
            for (int i = 0; i < splittedRaw.Length; i++)
            {
                if (!double.TryParse(splittedRaw[i], out parsedDoubles[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool TryParseDataInteger(string[] splittedRaw, out int[] parsedDoubles)
        {
            if ((splittedRaw == null) || (splittedRaw.Length == 0))
            {
                parsedDoubles = null;
                return false;
            }
            parsedDoubles = new int[splittedRaw.Length];
            for (int i = 0; i < splittedRaw.Length; i++)
            {
                if (!int.TryParse(splittedRaw[i], out parsedDoubles[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public double[] ReadDoublesFromConsoleUntilSuccess()
        {
            for (int i = 0; i < MAX_ATTEMPTS; i++)
            {
                Console.WriteLine(INPUT_QUERY);
                var rawData = GetRawData();
                if (rawData == EXIT_KEY)
                {
                    break;
                }
                var splittedData = SplitRawData(rawData);
                if (TryParseDataDouble(splittedData, out double[] returnValue))
                {
                    return returnValue;
                }
                else
                {
                    Console.WriteLine(MSG_INPUT_UNPARSABLE);
                }
            }
            return null;
        }
        public int[] ReadIntegersFromConsoleUntilSuccess()
        {
            for (int i = 0; i < MAX_ATTEMPTS; i++)
            {
                Console.WriteLine(INPUT_QUERY);
                var rawData = GetRawData();
                if (rawData == EXIT_KEY)
                {
                    break;
                }
                var splittedData = SplitRawData(rawData);
                if (TryParseDataInteger(splittedData, out int[] returnValue))
                {
                    return returnValue;
                }
                else
                {
                    Console.WriteLine(MSG_INPUT_UNPARSABLE);
                }
            }
            return new int[0];
        }
        public string[] GetRawAndSplit()
        {
            return SplitRawData(GetRawData());
        }
    }
}
