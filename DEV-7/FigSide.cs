using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    class FigSide
    {
        const double DEFAULT_LEN = 1;
        const string MSG_WARNING_LESS_ZERO_IN_SIDE_CONSTR = "Warning, trying to create less-zero side, creating default size side";
        public double GeomLength;
        public List<double> Position;
        public List<double> Orientation;
        public FigSide(double len)
        {
            if (len>0)
            {
                GeomLength = len;
            }
            else
            {
                Console.WriteLine(MSG_WARNING_LESS_ZERO_IN_SIDE_CONSTR);
                GeomLength = DEFAULT_LEN;
            }
        }
    }
}
