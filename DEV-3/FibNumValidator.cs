using System;

namespace DEV_3
{
    enum NumberValidStatus
    {
        ok = 0,
        unparsable = 1,
        lessZero = 2,
    }
    class FibNumValidator
    {
        private const string MSG_VALID = "Number is valid, proceeding";
        private const string MSG_ERROR_UNPARSABLE = "Number unparsable";
        private const string MSG_ERROR_LESSZERO = "Number is less than zero";
        private const string MSG_ERROR_UNKNOWN = "Unknown error code in FibNumValidator.ShowValidationStatus";

        public NumberValidStatus Validate(int number)
        {
            if (number < 0)
            {
                return NumberValidStatus.lessZero;
            }
            else
            {
                return NumberValidStatus.ok;
            }
        }
        public NumberValidStatus Validate(string numberString)
        {
            bool parseStatus = Int32.TryParse(numberString, out int parseResult);
            if (parseStatus)
            {
                return Validate(parseResult);
            }
            else
            {
                return NumberValidStatus.unparsable;
            }
        }
        public void ShowValidationStatus(NumberValidStatus errorCode)
        {
            switch (errorCode)
            {
                case NumberValidStatus.ok:
                    Console.WriteLine(MSG_VALID);
                    break;
                case NumberValidStatus.unparsable:
                    Console.WriteLine(MSG_ERROR_UNPARSABLE);
                    break;
                case NumberValidStatus.lessZero:
                    Console.WriteLine(MSG_ERROR_LESSZERO);
                    break;
                default:
                    Console.WriteLine(MSG_ERROR_UNKNOWN);
                    break;
            }
        }
    }
}
