using System;

namespace DEV_3
{
    
    class FibNumber
    {
        enum CheckIfFibStatus
        {
            notFib = 0,
            fib = 1
        }
        const string MSG_NUMBER_IS_FIB = "Number is one of Fibbonacci row";
        const string MSG_NUMBER_IS_NOT_FIB = "Number is NOT one of Fibbonacci row";
        const string MSG_UNKONW_INPUT_STATUS = "Unknown status code in FibNumber.ShowCheckStatus";
        public FibNumValidator Validator = new FibNumValidator();
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                NumberValidStatus validStat = Validator.Validate(value);
                Validator.ShowValidationStatus(validStat);
                if (validStat == NumberValidStatus.ok)
                {
                    CheckIfFibStatus checkFibStat = CheckIfFibonacci(value);
                    ShowCheckStatus(checkFibStat);
                    if (checkFibStat == CheckIfFibStatus.fib)
                    {
                        _number = value;
                    }
                }
            }
        }
        private CheckIfFibStatus CheckIfFibonacci(int numberToCheck)
        {
            int fibNum0 = 0;
            int fibNum1 = 1;
            int fibNumCurrent = fibNum1;
            while(fibNumCurrent <= numberToCheck)
            {
                if (fibNumCurrent == numberToCheck)
                {
                    return CheckIfFibStatus.fib;
                }
                fibNumCurrent = fibNum0 + fibNum1;
                fibNum0 = fibNum1;
                fibNum1 = fibNumCurrent;
            }
            return CheckIfFibStatus.notFib;
        }
        private void ShowCheckStatus(CheckIfFibStatus statusCode)
        {
            switch(statusCode)
            {
                case CheckIfFibStatus.fib:
                    Console.WriteLine(MSG_NUMBER_IS_FIB);
                    break;
                case CheckIfFibStatus.notFib:
                    Console.WriteLine(MSG_NUMBER_IS_NOT_FIB);
                    break;
                default:
                    Console.WriteLine(MSG_UNKONW_INPUT_STATUS);
                    break;
            }
        }
    }
}
