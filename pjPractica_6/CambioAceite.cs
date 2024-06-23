using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPractica_6
{
    public class CambioAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }

        public override double CalcularCosto()
        {
            return 50.0; // Costo del cambio de aceite
        }

        public override double CalcularTiempoServicio()
        {
            return 1.0; // Tiempo del servicio en horas
        }
    }
}
