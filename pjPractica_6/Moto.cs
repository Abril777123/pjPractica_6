using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPractica_6
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto: Lubricación de cadena y revisión de neumáticos.");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 100.0; // Costo del mantenimiento de la moto
        }
    }
}
