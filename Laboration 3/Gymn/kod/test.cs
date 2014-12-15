using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class test
    {
        public void testsvit()
        {
            // Skapar upp ett nytt objekt utav Sport
            Sport sportTest1 = new Sport("SportTest", "TestGymnast");

            // Starta mina tester.
            test1(sportTest1._administrator);
            test2(sportTest1._administrator);
            test3(sportTest1._administrator);
            test4(sportTest1._gymnast._score);
        }

        // Test case 1 - Antal domare
        public void test1(Admin adminTest)
        {
            // Testdata för anrop
            int[] first = {1, 10, 2, 4, 7, 7};
            int[] second = {1, 10, 2, 4, 7};
            int[] third = {1, 10, 2, 4, 7, 7, 4};

            // Samlar alla anrop i en list
            List<int[]> calls = new List<int[]>();
            calls.Add(first);
            calls.Add(second);
            calls.Add(third);

            // Kör alla anrop i en try catch sats som skriver ut meddelande beroende på utfall
            for (int i = 0; i < 3; i++)
            {
                string call = String.Join(",", calls[i]);
                
                try
                {
                    adminTest.registerScore(calls[i]);

                    //Display passed call
                    string success = String.Join(",", adminTest.InitialScore);
                    message("Test 1", call, success, true);
                }
                catch (Exception)
                {
                    // Display not passed call
                    message("Test 1", call, "Failed", false);
                }
            }
        }

        // Test 2 - Poängbedömningar
        public void test2(Admin adminTest)
        {
            //Testdata för anrop
            int[] first = { 1, 10, 2, 4, 7, 7 };
            int[] second = { 1, 12, 2, 4, 7, 7 };
            int[] third = { 1, 10, 2, 0, 7, 7 };

            //Samlar alla anrop i en list
            List<int[]> calls = new List<int[]>();
            calls.Add(first);
            calls.Add(second);
            calls.Add(third);

            //Kör alla anrop i en try catch sats som skriver ut meddelande beroende på utfall
            for (int i = 0; i < 3; i++)
            {
                string call = String.Join(",", calls[i]);

                try
                {
                    adminTest.InitialScore = calls[i];

                    //Display passed call
                    string success = String.Join(",", adminTest.InitialScore);
                    message("Test 2", call, success, true);
                }
                catch (Exception)
                {
                    //Display not passed call
                    message("Test 2", call, "Failed", false);
                }
            }
        }

        // Test 3 - Total poängen
        public void test3(Admin adminTest)
        {
            //Testdata för anrop
            int[] first = { 1, 10, 2, 4, 7, 7 };
            int[] second = { 1, 7, 2, 8, 7, 3 };
            int[] third = { 10, 10, 2, 3, 8, 7 };

            //Samlar alla anrop i en list
            List<int[]> calls = new List<int[]>();
            calls.Add(first);
            calls.Add(second);
            calls.Add(third);

            //Kör alla anrop i en try catch sats som skriver ut meddelande beroende på utfall
            for (int i = 0; i < 3; i++)
            {
                string call = String.Join(",", calls[i]);
                try
                {
                    adminTest.calculateFinalScore(calls[i]);

                    //Display passed call
                    string success = adminTest.FinalScore.ToString();
                    message("Test 3", call, success, true);
                }
                catch (Exception)
                {
                    //Display not passed call
                    message("Test 3", call, "Failed", false);
                }
            }
        }

        /// Test 4 - Sätter poängen
        public void test4(Score score)
        {
            // Testdata för anrop
            double first = 5;
            double second = 4.75;

            // Samlar alla anrop i en list
            List<double> calls = new List<double>();
            calls.Add(first);
            calls.Add(second);

            // Kör alla anrop i en try catch sats som skriver ut meddelande beroende på utfall
            for (int i = 0; i < 2; i++)
            {
                string call = calls[i].ToString();
                try
                {
                    score.ScoreOrg = calls[i];
                    string success = score.ScoreOrg.ToString();
                    message("Test 4", call, success, true);
                }
                catch (Exception)
                {
                    message("Test 4", call, "Failed", false);
                }
            }
        }

        // Skriver ut datan i consol fönstret.
        public void message(string testCase, string call, string result, bool color)
        {
            // Ställ in färg på meddelande beroende på true/false
            if (color == true)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            // Presentera testinformation och testdata
            Console.WriteLine("Testfall: {0}", testCase);
            Console.WriteLine("Anrop: {0}", call);
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();

            // Återställer färgen,
            Console.ResetColor();
        }
    }
}
