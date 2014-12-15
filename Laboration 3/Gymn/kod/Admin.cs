using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Admin
    {
        private int[] _score;
        private double _finalScore;

        public int[] InitialScore
        {
            get 
            {
                return _score; 
            }

            set 
            {
                //Make sure number of judges scores are 6 and make sure that all scores are in the intervall 1-10
                if (value.Length == 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (value[i] < 11 && value[i] > 0)
                        {
                            _score[i] = value[i];
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Poängbedömningen är utanför tillåtet intervall <1 - 10>");
                        }
                    }
                }

                else
                {
                    throw new ArgumentOutOfRangeException("Antalet poängbedömningar är utanför tillåtet intervall <6st>");
                }
            }
        }

        public double FinalScore
        {
            get { return _finalScore; }
            set { _finalScore = value; }
        }

        //Constructor
        public Admin()
        {
            _score = new int[6];
            FinalScore = 0.0;
        }

        /// <summary>
        /// Method taking care of judges score registration
        /// 
        /// For testing this method is kept as a setter to emulate inital scores. This method will later use readline and parse for the secretary to enter scores from the judges by hand.
        /// </summary>
        /// <returns>Array of initial scores</returns>
        public void registerScore(int[] input)
        {
            //Early version only uses setter function (to enable testing)
            InitialScore = input;
        }

        /// <summary>
        /// Calculates final score using judges scores
        /// </summary>
        /// <param name="scoreArray">Initial judges scores</param>
        /// <returns>Final score</returns>
        public void calculateFinalScore(int[] scoreArray)
        {
            //Declare variables
            double scoreCount = 0.0;
            
            //Sort scores
            Array.Sort(scoreArray);

            //Remove highest and lowest numbers and add all scores together
            for (int i = 1; i < 5; i++)
            {
                scoreCount += (double)scoreArray[i];
            }

            //Set final score
            FinalScore = scoreCount / 4.0;
        }

        /// <summary>
        /// Gives final score to competing gymnast
        /// </summary>
        /// <param name="score">Final score</param>
        /// <param name="gymnast">Gymnast that gets score</param>
        public void finalScoreRegistration(double score, Gymnast gymnast, bool userInput)
        {
            if (userInput == true)
            {
                gymnast.Score = score;
            }
            else
            {
                //tell user to input scores again - this is left blank for now but needs to be added before delivering the system (doesn't work with automated testing)
            }
            
        }
    }
}
