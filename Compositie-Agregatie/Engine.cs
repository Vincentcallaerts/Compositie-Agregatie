using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositie_Agregatie
{
    class Engine
    {
        public Crankshaft Crankshaft { get; set; }
        public Piston[] Pistons { get; set; }
        public Engine()
        {
            Crankshaft = new Crankshaft();
            Pistons = new Piston[8];
            Pistons[0] = new Piston();
            Pistons[1] = new Piston();
            Pistons[2] = new Piston();
            Pistons[3] = new Piston();
        }
    }
}
