﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Plato
    {
        public Plato(Alimento alimento1, Alimento alimento2)
        {
            this.alimento1 = alimento1;
            this.alimento2 = alimento2;
        }

        public Alimento alimento1 { get; private set; }
        public Alimento alimento2 { get; private set; }
    }
}
