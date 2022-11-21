using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalesLibreria
{
    public abstract class Animal
    {
        public int Edad { get; }
        public int Altura { get; }
        public int Peso { get; }

        public virtual string Imprimir()
        {
            return "Edad: "+Edad+" Altura: "+Altura+" Peso: "+Peso;
        }

        public abstract string ImprimirComida();

        public Animal(int edad, int altura, int peso)
        {
            Edad = edad;
            Altura = altura;
            Peso = peso;
        }   
    }
}
