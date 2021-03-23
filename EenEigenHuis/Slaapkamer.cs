using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Slaapkamer : Kamer
    {
        public Slaapkamer(int oppervlakte) : base(oppervlakte)
        {
            Prijs = 510;
        }
    }
}
