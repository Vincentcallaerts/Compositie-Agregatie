using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Living : Kamer
    {
        public bool HeeftSchouw { get; set; }
        public Living(int oppervlakte,bool heeftschouw) : base(oppervlakte)
        {
            HeeftSchouw = heeftschouw;
            if (HeeftSchouw == true)
            {
                Prijs = 700;
            }
            else
            {
                Prijs = 300;
            }
            
        }
    }
}
