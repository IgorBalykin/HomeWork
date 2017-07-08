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
            ConsoleReader mainReader = new ConsoleReader();
            double[] sides = mainReader.ReadDoublesFromConsoleUntilSuccess();
            Triangle trian = new Triangle(sides);
            Console.ReadKey();
        }
    }
}
