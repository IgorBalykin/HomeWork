using System;
using System.Collections.Generic;

namespace DEV_456
{
    class IntegerSequence
    {
        private const string MSG_INPUT_UNPARSABLE = "Can't create IntegerSequence, cosntructor input unparsable";
        private List<int> _numbers;
        public List<int> Numbers
        {
            get
            {
                return new List<int>(_numbers);
            }
            set
            {
                _numbers = new List<int>(value);
            }
        }
        public IntegerSequence()
        {
            _numbers = null;
        }
        public IntegerSequence(int[] inputSeq)
        {
            _numbers = new List<int>(inputSeq);
        }
        public IntegerSequence(string[] inputSeq)
        {
            if(TryParseStringSequence(inputSeq, out int[] parseResult))
            {
                _numbers = new List<int>(parseResult);
            }
            else
            {
                Console.WriteLine(MSG_INPUT_UNPARSABLE);
            }
        }
        public bool TryParseStringSequence(string[] inputSeq, out int[] outputSeq)
        {
            outputSeq = new int[inputSeq.Length];
            for(int i=0;i<inputSeq.Length;i++)
            {
                if (!Int32.TryParse(inputSeq[i], out outputSeq[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public void ShowSequenceInConsole()
        {
            if(_numbers!=null)
            {
                foreach(var number in _numbers)
                {
                    Console.Write(number.ToString() + ' ');
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
