using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Gang : Kamer
    {
        public Gang(int oppervlakte) : base(oppervlakte)
        {
            
            Prijs = 10 * Oppervlakte;
        }
    }
}
