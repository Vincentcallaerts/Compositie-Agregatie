using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class Moederbord
    {
        public Cpu Cpu { get; set; }
        public Fan Fan { get; set; }

        private Ram[] ramslots = new Ram[4];

        public Ram[] Ramslots
        {
            get { return ramslots; }
            set { ramslots  = value; }
        }
        public void TestMoederbord()
        {
            
            if (Cpu == null)
            {
                Console.WriteLine("Het moederbord heeft geen Cpu");
            }
           
            if (Fan == null)
            {
                Console.WriteLine("Het moederbord heeft geen Fan ");
            }
            int counter = 4;
            for (int i = 0; i < ramslots.Length; i++)
            {
                if (ramslots[i] != null)
                {
                    counter--;
                }
            }
            Console.WriteLine($"Het moederbord heeft {counter} ramslots beschikbaar ");
            Console.ReadLine();
        }
    }
}
