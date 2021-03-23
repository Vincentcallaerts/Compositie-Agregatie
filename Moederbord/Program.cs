using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class Program
    {
        static void Main(string[] args)
        {
            Moederbord moederbord = new Moederbord();

            moederbord.TestMoederbord();
            Cpu cpu = new Cpu("Niewe cpu");
            moederbord.Cpu = cpu;
            Ram ram = new Ram("powerram");
            moederbord.TestMoederbord();
            moederbord.Ramslots[0] = ram;
            moederbord.TestMoederbord();
        }
    }
}
