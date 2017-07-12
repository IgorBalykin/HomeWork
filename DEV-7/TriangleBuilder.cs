using System;

namespace DEV_7
{
    class TriangleBuilder
    {
        private const string MSG_UNABLE_TO_BUILD = "Unable to build triangle";
        TriangleTypeDeterminator Determinator = new TriangleTypeDeterminator();
        public Triangle Create(double[] sides)
        {
            Triangle inputTriangle = new Triangle(sides);
            switch (Determinator.DetermineType(inputTriangle))
            {
                case TriangleTypes.equilateral:
                    return new EquilateralTriangle(inputTriangle);
                case TriangleTypes.isosceles:
                    return new IsoscelesTriangle(inputTriangle);
                case TriangleTypes.scalene:
                    return new ScaleneTriangle(inputTriangle);
                default:
                    throw new Exception(MSG_UNABLE_TO_BUILD);
            }
        }
    }
}