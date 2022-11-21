using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalesLibreria
{
    public class Conejo:Animal
    {
        public int Saltos { get; set; }

        public override string ImprimirComida()
        {
            return "El Conejo come zanahorias";
        }
        public Conejo(int saltos, int edad, int altura, int peso)
            :base(edad, altura,peso)
        {
            Saltos = saltos;
        }
    }
}
