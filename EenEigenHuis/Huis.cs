using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Huis
    {

        public List<Kamer> Kamers { get; set; }
        public Huis()
        {
            Kamers = new List<Kamer>();
        }
        public void AddKamer(Kamer kamer)
        {
            Kamers.Add(kamer);
        }

        public void TotaalPrijs() 
        {
            int prijs = 0;
            foreach (var item in Kamers)
            {
                prijs += item.Prijs;
            }
            Console.WriteLine($"Dit huis kost {prijs} euro");
        }
    }
}
