using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_1_Ariel_Hernandez_202402123.Clases
{
    internal class Marcador
    {
        public double CostoHora { get; set; }
        public double CantidadHoras { get; set; }

        public double CalcularSueldo()
        {
            return CostoHora * CantidadHoras;
        }



    }
}
