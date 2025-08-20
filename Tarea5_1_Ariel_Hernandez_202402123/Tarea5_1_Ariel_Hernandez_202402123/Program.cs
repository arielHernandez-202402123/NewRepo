using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5_1_Ariel_Hernandez_202402123.Clases;

namespace Tarea5_1_Ariel_Hernandez_202402123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona(); // constructor para construir elobjeto persona.
            string nombreCompleto = string.Empty;


            persona.setNombre("Carlos"); // metodo para establecer el nombre de la persona.
            persona.setApellido("Sanchez"); // metodo para establecer el apellido de la persona.

            nombreCompleto = persona.getNombreCompleto(); // metodo para obtener el nombre completo de la persona.

            Console.WriteLine("Persona 1 "+ nombreCompleto);

            nombreCompleto = persona.getNombreCompleto("Ariel", "Hernandez"); // 2do metodo para obtener el nombre completo de la persona con parametro (polimorfismo).

            Console.WriteLine("Persona 2 " + nombreCompleto);

            Marcador marcador = new Marcador(); // constructor para construir el objeto marcador.

            marcador.CostoHora = 50; // establecer el costo por hora.
            marcador.CantidadHoras = 160; // establecer la cantidad de horas trabajadas.
            double sueldo = marcador.CalcularSueldo(); // calcular el sueldo.
            Console.WriteLine("Sueldo: " + sueldo);
            Console.ReadLine();

        }
    }
}
