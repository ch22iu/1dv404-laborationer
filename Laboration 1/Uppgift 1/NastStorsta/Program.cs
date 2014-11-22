using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int biggest = 0;
            int secondBiggest = 0;
            string temp = string.Empty;
            string input;
            
            Console.Write("Mata in 10 heltal:");

                                            
            input = Console.ReadLine();

            int i = 0;
            foreach (var tal in input)
            {                
                i++;

                if (i == input.Length) 
                {
                    temp += tal;
                }
                
                    if (tal != ' ' && i != input.Length)
                {
                    temp += tal;                    
                }
                else
                {
                    int number;
                    int.TryParse(temp, out number);

                    if (number > biggest)
                    {
                        secondBiggest = biggest;
                        biggest = number;
                    }
                    else if (number > secondBiggest)
                    {
                        secondBiggest = number;

                    }

                    temp = string.Empty;
                }

            }

            Console.WriteLine("Det näst största heltalet är : {0}", secondBiggest);
            
            Console.ReadLine();
        }
    }
}
