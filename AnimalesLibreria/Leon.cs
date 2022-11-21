using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalesLibreria
{
    public class Leon:Animal
    {
        public int Cacerias { get; set; }

        public override string ImprimirComida()
        {
            return "El leon come impalas"; 
        }
        public Leon(int cacerias, int edad, int altura, int peso)
            :base(edad, altura, peso)
        {
            Cacerias = cacerias;
        }
    }
}
