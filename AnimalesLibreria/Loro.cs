using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalesLibreria
{
    public class Loro:Animal
    {
        public string Frases { get; set; }

        public override string ImprimirComida()
        {
            return "El loro come semillas";
        }

        public Loro(string frases, int edad, int altura, int peso)
            :base(edad, altura, peso)
        {
            Frases = frases;
        }

    }
}
