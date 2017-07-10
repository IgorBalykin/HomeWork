using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_456
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ConsoleReader mainReader = new ConsoleReader();    
            int[] splittedIntegerData = mainReader.ReadIntegersFromConsoleUntilSuccess();
            IntegerSequence mainSeq = new IntegerSequence(splittedIntegerData);
            Console.ReadKey();
        }
    }
}
