using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Score
    {
        private string _sportName;
        private double _scoreOrg;

        public string SportName
        {
            get 
            { 
                return _sportName; 
            }

            set 
            { 
                _sportName = value; 
            }
        }

        public double ScoreOrg
        {
            get 
            { 
                return _scoreOrg; 
            }

            set 
            { 
                _scoreOrg = value; 
            }
        }

        public Score(string sport)
        {
            SportName = sport;
            ScoreOrg = 0.0;
        }
    }
}
