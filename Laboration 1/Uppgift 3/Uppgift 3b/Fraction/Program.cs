using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar upp ett nytt objekt utav Fraction klassen samt skicka med argument
			
            Fraction firstFraction = new Fraction(1, 3);
            Fraction secondFraction = new Fraction(-1, 3);

            // Skriver ut en text sträng med Fraction.add som jag skickar med firstFraction 
			// samt andra lägger till ny rad samt skickar jag med nämnaren, täljaren och andra Nämnaren.
			
            Console.WriteLine(calc.newAddi + Fraction.add(firstFraction, secondFraction) + calc.row,
                firstFraction.Numerator, firstFraction.Denominator, secondFraction.Numerator, secondFraction.Denominator);

            // Skriver ut en text sträng med Fraction.multiply som jag skickar med firstFraction 
			// samt andra lägger till ny rad samt skickar jag med nämnaren, täljaren och andra Nämnaren.
			
            Console.WriteLine(calc.newMulti + Fraction.multiply(firstFraction, secondFraction) + calc.row,
                firstFraction.Numerator, firstFraction.Denominator, secondFraction.Numerator, secondFraction.Denominator);

            Console.ReadLine();
        }
    }
}