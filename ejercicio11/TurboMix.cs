using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class TurboMix : ITurboMix
    {
        //45 min
        public Plato Cocina(Alimento alimento1, Alimento alimento2) {
            Pesa(alimento1);
            Pesa(alimento2);
            Calienta(alimento1, alimento2);
            return new Plato(alimento1, alimento2);
        }

        private float Pesa(Alimento alimento)
        {
            return alimento.peso;
        }

        private void Calienta(Alimento alimento1, Alimento alimento2)
        {
            alimento1.caliente = true;
            alimento2.caliente = true;
    
        }
                
    }
}
