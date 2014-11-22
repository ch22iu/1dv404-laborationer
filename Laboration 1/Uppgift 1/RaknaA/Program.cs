using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en textrad:");
            string input = Console.ReadLine();

            int countSmalla = input.Count(c => c == 'a');
            int countBigA = input.Count(c => c == 'A');

            Console.WriteLine("Antal a: {0}\nAntal A: {1}", countSmalla, countBigA);
            Console.ReadLine();
        }
    }
}
