using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar upp ett nytt test och sedan kör klassen (fixture)

            Integrationstest test = new Integrationstest();
            test.fixture();

            // Bara för att kunna se testet (Slipper att gå in)

            Console.ReadLine();
        }
    }
}
