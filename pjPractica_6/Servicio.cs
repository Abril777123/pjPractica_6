﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPractica_6
{
    public abstract class Servicio
    {
        public abstract void RealizarServicio();
        public abstract double CalcularCosto();
        public abstract double CalcularTiempoServicio(); // Nuevo método para calcular el tiempo de servicio
    }
}
