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
            IntegerSequence mainSeq = new IntegerSequence();
            string[] splittedData = mainReader.GetRawAndSplit();
            if(mainSeq.TryParseStringSequence(splittedData, out int[] outputSeq))
            {
                mainSeq.Numbers = new List<int>(outputSeq);
            }
            Console.ReadKey();
        }
    }
}
