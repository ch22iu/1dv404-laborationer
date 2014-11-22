using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers;
            string input;
            int zeroes = 0;
            int even = 0;
            int odd = 0;
                      
            Console.Write(message.Heltal);
           

            input = Console.ReadLine();
              
            numbers = new int[input.Length];
             
              
            for (int i = 0; i < input.Length; i++)
            {
                int.TryParse(input[i].ToString(), out numbers[i]);                
            }

            foreach (var num in numbers)
            {
                if (num == 0)
                {
                    zeroes++;
                }
                else if (num % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

            }

            Console.WriteLine(message.HeltalAlla, zeroes, odd, even);
            Console.ReadLine();
        }
    }
}
