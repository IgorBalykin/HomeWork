using System;

namespace DEV_7
{
    class IsoscelesTriangle : Triangle
    {
        private const string _MSG_TYPE_OF_TRIANGLE = "This is isosceles triangle";
        protected override string MSG_TYPE_OF_TRIANGLE
        {
            get
            {
                return _MSG_TYPE_OF_TRIANGLE;
            }
        }
        private const string EXCEPTION_TEXT = "Trying to define not valid IsoscelesTriangle";
        public IsoscelesTriangle(Triangle inputTriangle)
        {
            TriangleTypeDeterminator determinator = new TriangleTypeDeterminator();
            if (determinator.DetermineType(inputTriangle) != TriangleTypes.isosceles)
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
