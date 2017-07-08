using System;

namespace DEV_7
{
    enum TriangleTypes
    {
        scalene = 0, //обычный
        isosceles = 1, //равнобедреный
        equilateral = 2 //равносторонний
    }
    class TriangleTypeDeterminator
    {
        public const string MSG_TYPE_SCALENE = "Triangle is scalene (all sides different)";
        public const string MSG_TYPE_ISOSCELES = "Triangle is isosceles (only two sides equal)";
        public const string MSG_TYPE_EQUILATERAL = "Triangle is equilateral (all sides equal)";
        public const string MSG_TYPE_UNKNOWN = "Unknown triangle type detected";
        private const double EPSILON = 0.000000001;

        public TriangleTypes DetermineType(Triangle triangle)
        {
            double[] sideLength = triangle.GetSidesLength().ToArray();
            double a = sideLength[0];
            double b = sideLength[1];
            double c = sideLength[2];
            bool abEqual = IfNearEqual(a, b);
            bool acEqual = IfNearEqual(a, c);
            bool bcEqual = IfNearEqual(b, c);
            if (abEqual && acEqual && bcEqual)
            {
                return TriangleTypes.equilateral;
            }
            else if (abEqual || acEqual || bcEqual)
            {
                return TriangleTypes.isosceles;
            }
            else
            {
                return TriangleTypes.scalene;
            }
        }
        public void ShowTypeInfo(TriangleTypes triangleType)
        {
            switch (triangleType)
            {
                case (TriangleTypes.scalene):
                    Console.WriteLine(MSG_TYPE_SCALENE);
                    break;
                case (TriangleTypes.isosceles):
                    Console.WriteLine(MSG_TYPE_ISOSCELES);
                    break;
                case (TriangleTypes.equilateral):
                    Console.WriteLine(MSG_TYPE_EQUILATERAL);
                    break;
                default:
                    Console.WriteLine(MSG_TYPE_UNKNOWN);
                    break;
            }
        }
        public void DetermineAndShowType(Triangle triangle)
        {
            ShowTypeInfo(DetermineType(triangle));
        }
        private bool IfNearEqual(double a, double b)
        {
            if (Math.Abs(a - b) < EPSILON)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
