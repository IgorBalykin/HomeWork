using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            Triangle trian = new Triangle(new double[3] {5,1,1});
            Console.WriteLine(trian.GetPerimeter().ToString());
            Console.ReadKey();
        }
    }
}
