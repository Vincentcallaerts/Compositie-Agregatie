using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Kamer
    {
        public int Prijs { get; set; }
        public int Oppervlakte { get; set; }
        public Kamer(int oppervlakte)
        {
            Oppervlakte = oppervlakte;
            Prijs = 400;
        }
    }
}
