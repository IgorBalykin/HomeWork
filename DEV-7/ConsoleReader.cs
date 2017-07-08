using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
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
            for(int i=0;i<splittedRaw.Length;i++)
            {
                if(!double.TryParse(splittedRaw[i],out parsedDoubles[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public double[] ReadDoublesFromConsoleUntilSuccess()
        {
            for(int i=0;i<MAX_ATTEMPTS;i++)
            {
                Console.WriteLine(INPUT_QUERY);
                var rawData = GetRawData();
                if(rawData==EXIT_KEY)
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
    }
}
