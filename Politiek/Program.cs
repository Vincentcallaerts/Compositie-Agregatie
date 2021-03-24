using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class Program
    {
        static void Main(string[] args)
        {

            Land land = new Land();
            President putin = new President();
            putin.Naam = "Putin deez nuts";
            List<Minister> test = new List<Minister>();
            test.Add(new Minister());
            test.Add(new Minister());
            test.Add(new Minister());
            test.Add(new Minister());
            test.Add(new Minister());
            test[0].Naam = "Ruddy";
            test[1].Naam = "Lene";
            land.MaakRegering(putin,test);
            putin.JaarVerder();
            land.MaakRegering(putin, test);
            putin.JaarVerder();
            land.MaakRegering(putin, test);
            putin.JaarVerder();
            land.MaakRegering(putin, test);
            putin.JaarVerder();
            test[0].Naam = "luddy";
            test[1].Naam = "wenen";
            land.MaakRegering(putin, test);
            land.MaakRegering(putin, test);

        }
    }
}
