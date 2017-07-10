using System;

namespace DEV_456
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ConsoleReader mainReader = new ConsoleReader();    
            int[] splittedIntegerData = mainReader.ReadIntegersFromConsoleUntilSuccess();
            IntegerSequence mainSeq = new IntegerSequence(splittedIntegerData);
            SequenceAnalyzer mainAnalyzer = new SequenceAnalyzer();
            mainAnalyzer.CheckSequenceAndPrintType(mainSeq);
            Console.ReadKey();
        }
    }
}
