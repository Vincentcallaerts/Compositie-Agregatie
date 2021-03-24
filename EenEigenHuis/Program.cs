using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Program
    {
        static void Main(string[] args)
        {

            Huis huis = new Huis();
            Gang gang = new Gang(5);
            huis.AddKamer(gang);
            Living living = new Living(40, false);
            huis.AddKamer(living);
            huis.TotaalPrijs();
            Console.ReadLine();

        }
    }
}
