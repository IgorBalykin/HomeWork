using System;

namespace DEV_7
{
    class EquilateralTriangle : Triangle
    {
        private const string _MSG_TYPE_OF_TRIANGLE = "This is equilateral triangle";
        protected override string MSG_TYPE_OF_TRIANGLE
        {
            get
            {
                return _MSG_TYPE_OF_TRIANGLE;
            }
        }
        private const string EXCEPTION_TEXT = "Trying to define not valid EquilateralTriangle";
        public EquilateralTriangle(Triangle inputTriangle)
        {
            TriangleTypeDeterminator determinator = new TriangleTypeDeterminator();
            if (determinator.DetermineType(inputTriangle) != TriangleTypes.equilateral)
            {
                throw new Exception(EXCEPTION_TEXT);
            }
            else
            {
                Sides = inputTriangle.Sides;
            }
        }
    }
}
