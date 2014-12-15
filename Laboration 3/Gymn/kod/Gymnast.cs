using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Gymnast
    {
        private string _name;
        public Score _score;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Score
        {
            get { return _score.ScoreOrg; }
            set { _score.ScoreOrg = value; }
        }

        public Gymnast(string name, string sport)
        {
            Name = name;
            _score = new Score(sport);
        }
    }
}
