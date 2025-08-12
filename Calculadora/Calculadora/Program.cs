using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("****Bienvenido a la Calculadora de Sueldo****");
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
        
            Console.Write("Ingrese el Costo de hora trabajada: ");
            double costoHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
            double cantidadHoras = Convert.ToDouble(Console.ReadLine());

            int totalDevengado = (int)(costoHora * cantidadHoras);
            Console.WriteLine($"Hola {nombre}, el total devengado por {cantidadHoras} horas trabajadas a un costo de L{costoHora} por hora es: L{totalDevengado}");


        }
    }
}