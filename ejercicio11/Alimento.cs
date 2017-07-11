using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Alimento
    {

        public Alimento(float peso)
        {
            this.peso = peso;
        }
        public Alimento() { }

        public float peso { get; private set; }
        public bool caliente { get; set; }
    }
}
