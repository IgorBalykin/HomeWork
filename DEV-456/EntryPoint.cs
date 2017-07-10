using System;
using System.Collections.Generic;

namespace DEV_456
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ConsoleReader mainReader = new ConsoleReader();
            IntegerSequence mainSeq = new IntegerSequence();
            if (mainReader.TryParseDataInteger(args, out int[] parseResult))
            {
                mainSeq.Numbers = new List<int>(parseResult);
            }
            else
            {
                int[] splittedIntegerData = mainReader.ReadIntegersFromConsoleUntilSuccess();
                mainSeq.Numbers = new List<int>(splittedIntegerData);
            }
            SequenceAnalyzer mainAnalyzer = new SequenceAnalyzer();
            //mainAnalyzer.CheckSequenceAndPrintType(mainSeq); //same thing below, literally expanding method definition from body of class
            mainAnalyzer.ShowSequenceTypeToConsole(mainAnalyzer.CheckIfSequenceIsNonDecreasing(mainSeq));
            Console.ReadKey();
        }
    }
}
