using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositie_Agregatie
{
    class Person
    {
        public Head Head { get; set; }
        public Hand[] Hands { get; set; }
        public Leg[] Legs { get; set; }

        public Person()
        {
            Head = new Head();
            Hands = new Hand[2];
            Hands[0] = new Hand();
            Hands[1] = new Hand();
            Legs = new Leg[2];
            Legs[0] = new Leg();
            Legs[1] = new Leg();
        }
    }
}
