using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class President : Minister
    {

        private int resterendeTijd = 4;

        public int ResterendeTijd
        {
            get { return resterendeTijd; }
            private set { resterendeTijd = value; }
        }

        public void JaarVerder() 
        {
            resterendeTijd--;
        }
    }
}
