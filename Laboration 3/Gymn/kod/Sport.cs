using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Sport
    {
        public string _name;
        public Admin _administrator;
        public Gymnast _gymnast;

        // Namn, Administrator, gymnast. Lägger till ny admin och ny gymnast

        public Sport(string name, string gymnast)
        {
            _name = name;
            _administrator = new Admin();
            _gymnast = new Gymnast(gymnast, name);
        }
    }
}
