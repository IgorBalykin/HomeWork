using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_456
{
    enum SequenceType
    {
        nonDecreasing = 0,
        usual = 1,
        empty = 3
    }
    class SequenceAnalyzer
    {
        private const string MSG_SEQTYPE_EMPTY = "Seqeunce empty";
        private const string MSG_SEQTYPE_NONDECR = "Sequence is non-decreasing";
        private const string MSG_SEQTYPE_USUAL = "Sequence is ordinary";
        private const string MSG_SEQTYPE_UNKNOWN = "Sequence unknown, probably wrong argument in SequenceType";
        public SequenceType CheckIfSequenceIsNonDecreasing(IntegerSequence inputSequence)
        {
            if (inputSequence.Numbers == null)
            {
                return SequenceType.empty;
            }
            var sequenceToCheck = inputSequence.Numbers;
            for(int i =1;i<sequenceToCheck.Count;i++)
            {
                if(sequenceToCheck[i]<sequenceToCheck[i-1])
                {
                    return SequenceType.usual;
                }
            }
            return SequenceType.nonDecreasing;
        }
        public void ShowSequenceTypeToConsole(SequenceType inputType)
        {
            switch (inputType)
            {
                case SequenceType.empty:
                    Console.WriteLine(MSG_SEQTYPE_EMPTY);
                    break;
                case SequenceType.nonDecreasing:
                    Console.WriteLine(MSG_SEQTYPE_NONDECR);
                    break;
                case SequenceType.usual:
                    Console.WriteLine(MSG_SEQTYPE_USUAL);
                    break;
                default:
                    Console.WriteLine(MSG_SEQTYPE_UNKNOWN);
                    break;
            }
        }
        public void CheckSequenceAndPrintType(IntegerSequence inputSequence)
        {
            ShowSequenceTypeToConsole(CheckIfSequenceIsNonDecreasing(inputSequence));
        }
    }
}
