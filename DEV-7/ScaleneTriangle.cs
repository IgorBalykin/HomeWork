namespace DEV_7
{
    class ScaleneTriangle : Triangle
    {
        private const string _MSG_TYPE_OF_TRIANGLE = "This is scalene triangle";
        protected override string MSG_TYPE_OF_TRIANGLE
        {
            get
            {
                return _MSG_TYPE_OF_TRIANGLE;
            }
        }
        public ScaleneTriangle(Triangle inputTriangle)
        {
            Sides = inputTriangle.Sides;
        }
    }
}
