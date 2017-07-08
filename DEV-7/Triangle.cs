using System;
using System.Collections.Generic;

namespace DEV_7
{
    class Triangle : Figure
    {
        private const string MSG_WARNING_NO_TRIANGLE_EXISTS = "Warning! No triangle with defined sides exists";
        private const int NUMBER_OF_SIDES = 3;
        private const string MSG_WARNING_NULLPOINTER_IN_CONSTR = "Warning! Someone passed a nullpointer in triangle constructor";
        private List<FigSide> _sides;
        public List<FigSide> Sides
        {
            get
            {
                return new List<FigSide>(_sides);
            }
            set
            {
                if (CheckIfFigure(value))
                {
                    _sides = new List<FigSide>(value);
                }
                else
                {
                    Console.WriteLine(MSG_WARNING_NO_TRIANGLE_EXISTS);
                }
            }
        }
        public Triangle(List<FigSide> sideList)
        {
            if (sideList == null)
            {
                Console.WriteLine(MSG_WARNING_NULLPOINTER_IN_CONSTR);
                return;
            }
            Sides = sideList;
        }
        public Triangle(double[] doubleSideList)
        {
            if (doubleSideList == null)
            {
                Console.WriteLine(MSG_WARNING_NULLPOINTER_IN_CONSTR);
                return;
            }
            if (doubleSideList.Length == NUMBER_OF_SIDES)
            {
                var tempList = new List<FigSide>(NUMBER_OF_SIDES);
                foreach (var sideLen in doubleSideList)
                {
                    tempList.Add(new FigSide(sideLen));
                }
                Sides = tempList;
            }
            else
            {
                Console.WriteLine(MSG_WARNING_NO_TRIANGLE_EXISTS);
            }
        }
        public override bool CheckIfFigure(List<FigSide> inputToCheck)
        {
            //check if triangle exists
            if (inputToCheck.Count != 3)
            {
                return false;
            }
            FigSide a = inputToCheck[0];
            FigSide b = inputToCheck[1];
            FigSide c = inputToCheck[2];
            bool checkA = a.GeomLength < b.GeomLength + c.GeomLength;
            bool checkB = b.GeomLength < a.GeomLength + c.GeomLength;
            bool checkC = c.GeomLength < b.GeomLength + a.GeomLength;
            if (checkA && checkB && checkC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetNumberOfSides()
        {
            return _sides.Count;
        }
        public override List<double> GetSidesLength()
        {
            var returnList = new List<double>(_sides.Count);
            for (int i = 0; i < _sides.Count; i++)
            {
                returnList[i] = _sides[i].GeomLength;
            }
            return returnList;
        }
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
        public override double GetPerimeter()
        {
            double perimeter = 0;
            foreach (var side in _sides)
            {
                perimeter += side.GeomLength;
            }
            return perimeter;
        }
    }
}
