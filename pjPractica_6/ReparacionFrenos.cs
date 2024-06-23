using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPractica_6
{
    public class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparación de frenos.");
        }

        public override double CalcularCosto()
        {
            return 100.0; // Costo de la reparación de frenos
        }

        public override double CalcularTiempoServicio()
        {
            return 2.0; // Tiempo del servicio en horas
        }
    }
}
