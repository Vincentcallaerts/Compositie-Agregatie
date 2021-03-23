using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class Land
    {
        private President president;
        private Minister eersteMinister;
        private List<Minister> ministers;



        public List<Minister> Ministers
        {
            get { return ministers; }
            set { ministers = value; }
        }

        public Minister EersteMinister
        {
            get { return eersteMinister; }
            set { eersteMinister = value; }
        }

        public President President
        {
            get { return president; }
            set { president = value; }
        }

        public void MaakRegering(President president, List<Minister> ministers)
        {
            if (this.president == null)
            {
                this.president = president;
                eersteMinister = ministers[0];
                ministers.RemoveAt(0);
                this.ministers = ministers;
                Console.WriteLine($"De nieuwe regering werd aangemaakt met {this.president.Naam} als president, {this.eersteMinister.Naam} als eerste minister en {this.ministers[0].Naam} als de tweede enzo....");
            }
            else if (this.president.ResterendeTijd == 0)
            {
                Console.WriteLine("De regering werd verwijderd");
                this.president = null;
                this.eersteMinister = null;
                this.ministers = null;

            }
            else
            {
                Console.WriteLine($"Er is al een regering en de president heeft nog {this.president.ResterendeTijd} jaren te gaan");
            }
            Console.ReadLine();
        }
    }
}
