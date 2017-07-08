using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    abstract class Figure
    {
        abstract public double GetArea();
        abstract public double GetPerimeter();
        abstract public int GetNumberOfSides();
        abstract public List<double> GetSidesLength();
        abstract public bool CheckIfFigure(List<FigSide> inputToCheck);
    }
}
