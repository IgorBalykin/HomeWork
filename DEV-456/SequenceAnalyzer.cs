using System;

namespace DEV_456
{
    enum SequenceType
    {
        NonDecreasing = 0,
        Usual = 1,
        Empty = 3
    }
    class SequenceAnalyzer
    {
        private const string MSG_SEQTYPE_EMPTY = "Seqeunce empty";
        private const string MSG_SEQTYPE_NONDECR = "Sequence is non-decreasing";
        private const string MSG_SEQTYPE_USUAL = "Sequence is ordinary";
        private const string MSG_SEQTYPE_UNKNOWN = "Sequence unknown, probably wrong argument in SequenceType";
        public SequenceType CheckIfSequenceIsNonDecreasing(IntegerSequence inputSequence)
        {
            if ((inputSequence.Numbers == null) || (inputSequence.Numbers.Count==0))
            {
                return SequenceType.Empty;
            }
            var sequenceToCheck = inputSequence.Numbers;
            for (int i = 1; i < sequenceToCheck.Count; i++)
            {
                if (sequenceToCheck[i] < sequenceToCheck[i - 1])
                {
                    return SequenceType.Usual;
                }
            }
            return SequenceType.NonDecreasing;
        }
        public void ShowSequenceTypeToConsole(SequenceType inputType)
        {
            switch (inputType)
            {
                case SequenceType.Empty:
                    Console.WriteLine(MSG_SEQTYPE_EMPTY);
                    break;
                case SequenceType.NonDecreasing:
                    Console.WriteLine(MSG_SEQTYPE_NONDECR);
                    break;
                case SequenceType.Usual:
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
