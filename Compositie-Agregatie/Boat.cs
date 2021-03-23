using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositie_Agregatie
{
    class Boat
    {
        public Engine Engine { get; set; }
        public Propeller[] Propellers { get; set; }

        public Boat()
        {
            Propellers = new Propeller[4];
            Propellers[0] = new Propeller();
            

        }
    }
}
