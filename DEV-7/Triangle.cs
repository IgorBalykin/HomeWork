﻿using System;
using System.Collections.Generic;

namespace DEV_7
{
    class Triangle : Figure
    {
        private const string MSG_WARNING_NO_TRIANGLE_EXISTS = "Warning! No triangle with defined sides exists, creating default triangle";
        private const int NUMBER_OF_SIDES = 3;
        private const string MSG_WARNING_NULLPOINTER_IN_CONSTR = "Warning! Someone passed a nullpointer in triangle constructor, creating default triangle";
        private readonly double[] DEFAULT_SIDES_SET = new double[] { 1, 1, 1 };
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
                SetTriangleSides(DEFAULT_SIDES_SET);
            }
            else
            {
                Sides = sideList;
            }
        }
        public Triangle(double[] doubleSideList)
        {
            if (!SetTriangleSides(doubleSideList))
            {
                SetTriangleSides(DEFAULT_SIDES_SET);
            }
        }
        public bool SetTriangleSides(double[] doubleSideList)
        {
            if (doubleSideList == null)
            {
                Console.WriteLine(MSG_WARNING_NULLPOINTER_IN_CONSTR);
                return false;
            }
            if (doubleSideList.Length == NUMBER_OF_SIDES)
            {
                var tempList = new List<FigSide>(NUMBER_OF_SIDES);
                foreach (var sideLen in doubleSideList)
                {
                    tempList.Add(new FigSide(sideLen));
                }
                Sides = tempList;
                return true;
            }
            else
            {
                Console.WriteLine(MSG_WARNING_NO_TRIANGLE_EXISTS);
                return false;
            }
        }
        public override bool CheckIfFigure(List<FigSide> inputToCheck)
        {
            //check if triangle exists
            if (inputToCheck.Count != NUMBER_OF_SIDES)
            {
                return false;
            }
            double aLength = inputToCheck[0].GeomLength;
            double bLength = inputToCheck[1].GeomLength;
            double cLength = inputToCheck[2].GeomLength;
            bool checkA = aLength <= bLength + cLength;
            bool checkB = bLength <= aLength + cLength;
            bool checkC = cLength <= bLength + aLength;
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
            foreach (var side in _sides)
            {
                returnList.Add(side.GeomLength);
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