using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    class FigSide
    {
        public double GeomLength;
        public List<double> Position;
        public List<double> Orientation;
        public FigSide(double len)
        {
            GeomLength = len;
        }
    }
}
