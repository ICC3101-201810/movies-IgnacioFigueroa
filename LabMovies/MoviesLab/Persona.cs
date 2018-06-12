using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public enum Tipo { Actor, Director, Productor}
    public class Persona
    {
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        string fechadeNacimiento;
        string biografia;
        public Tipo tipo { get; private set; }

        public Persona(string nombre, string apellido, string fechadeNacimiento, string biografia, Tipo tipo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechadeNacimiento = fechadeNacimiento;
            this.biografia = biografia;
            this.tipo = tipo;
        }
    }
}
