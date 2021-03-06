﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Integrationstest
    {
        //Declaring fields emulating judges scores and strings for messages used in test cases
        int[] testScore = { 7, 6, 10, 8, 5, 8 };
        int[] testScoreTwo = { 7, 7, 10, 8, 8, 10 };
        string success;
        string call;

        public void fixture()
        {
            //Set-up test fixture
            Sport sportTest = new Sport("TestSport", "TestGymnast");

            //Execute tests
            runTestA01(sportTest._administrator, sportTest._gymnast);
            runTestA01B(sportTest._administrator, sportTest._gymnast); 
        }

        // Test 1A

        private void runTestA01(Admin adminTest, Gymnast gymnast)
        {
            //1. Enter judges scores
            try
            {
                adminTest.registerScore(testScore);

                //Display passed call
                success = String.Join(",", adminTest.InitialScore);
                message("Test 1A", "Register score", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = String.Join(",", testScore);
                message("Test 1A", "Failed register score", call, false);
            }

            //2. Calculate final score
            try
            {
                adminTest.calculateFinalScore(adminTest.InitialScore);

                //Display passed call
                success = adminTest.FinalScore.ToString();
                message("Test 1A", "Calculate final score", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = adminTest.InitialScore.ToString();
                message("Test 1A", "Failed: Calculate final score", call, false);
            }

            //3 & 4. Give thumbs up and register gymnast score
            try
            {
                adminTest.finalScoreRegistration(adminTest.FinalScore, gymnast, true);

                //Display passed call
                success = gymnast.Score.ToString();
                message("Test 1A", "Thumbs up", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = adminTest.FinalScore.ToString();
                message("Test 1A", "Failed: Thumbs up", call, false);
            }
        }

        // Test 1B
        private void runTestA01B(Admin adminTest, Gymnast gymnast)
        {
            //1. Enter judges scores
            try
            {
                adminTest.registerScore(testScore);

                //Display passed call
                success = String.Join(",", adminTest.InitialScore);
                message("Test 2A", "Register score", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = String.Join(",", testScore);
                message("Test 2A", "Failed register score", call, false);
            }

            //2. Calculate final score
            try
            {
                adminTest.calculateFinalScore(adminTest.InitialScore);

                //Display passed call
                success = adminTest.FinalScore.ToString();
                message("Test 2A", "Calculate final score", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = adminTest.InitialScore.ToString();
                message("Test 2A", "Failed: Calculate final score", call, false);
            }

            //3. Give thumbs down and don´t register gymnast score
            try
            {
                adminTest.finalScoreRegistration(adminTest.FinalScore, gymnast, false);

                //Display passed call
                success = "Score not set";
                message("Test 2A", "Thumbs down", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = adminTest.FinalScore.ToString();
                message("Test 2A", "Failed: Thumbs down", call, false);
            }

            //4. Enter judges scores again with new input simulating correcting the scores
            try
            {
                adminTest.registerScore(testScoreTwo);

                //Display passed call
                success = String.Join(",", adminTest.InitialScore);
                message("Test 2A", "Register score again", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = String.Join(",", testScore);
                message("Test 2A", "Failed register score again", call, false);
            }

            //5. Calculate final score with the new "corrected" judges scores
            try
            {
                adminTest.calculateFinalScore(adminTest.InitialScore);

                //Display passed call
                success = adminTest.FinalScore.ToString();
                message("Test 2A", "Calculate final score again", success, true);
            }
            catch (Exception)
            {
                //Display not passed call
                call = adminTest.InitialScore.ToString();
                message("Test 2A", "Failed: Calculate final score again", call, false);
            }

            //6 & 7. Give thumbs up and register gymnast score after being satisfied with the new final score
            try
            {
                adminTest.finalScoreRegistration(adminTest.FinalScore, gymnast, true);
                success = gymnast.Score.ToString();
                message("Test 2B", "Thumbs up second time", success, true);
            }
            catch (Exception)
            {
                call = adminTest.FinalScore.ToString();
                message("Test 2B", "Failed: Thumbs up second time", call, false);
            }
        }


        // Visar test datan i consol fönstret.

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
            Console.WriteLine("Test: {0}", call);
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();

            // Återställ färg
            Console.ResetColor();
        }
    }
}
