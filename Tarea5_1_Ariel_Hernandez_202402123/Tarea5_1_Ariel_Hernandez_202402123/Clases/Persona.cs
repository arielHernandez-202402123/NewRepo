using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_1_Ariel_Hernandez_202402123.Clases
{
    internal class Persona
    {

        private string nombre { get; set; }
        public string id { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string numTelefono   { get; set; }
        public string numCelular { get; set; }
        public string email { get; set; }


        public Persona()
        {
            nombre = "Ariel";
        }

        public string getNombre() // metodo para obtener el nombre de la persona.
        {
            return this.nombre;
        }

        public void setNombre(string p_nombre) // metodo para establecer el nombre de la persona.
        {
            this.nombre = p_nombre;
        }

        public void setApellido(string p_apellido) // metodo para establecer el apellido de la persona.
        {
            this.apellido = p_apellido;
        }

        public string getApellido() // metodo para obtener el apellido de la persona.
        {
            return this.apellido;
        }

        public string getNombreCompleto() // metodo para obtener el nombre completo de la persona.
        {
            return this.nombre + " " + this.apellido;
        }

        public string getNombreCompleto(string p_nombre, string p_apellido) // 2do metodo para obtener el nombre completo de la persona con parametro (polimorfismo).
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            return this.nombre + " " + this.apellido;
        }

    }
}
