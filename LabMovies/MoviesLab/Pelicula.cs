using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class Pelicula
    {
        public string nombre { get; private set; };
        Persona director;
        string fechaDeEstreno;
        string descirpcion;
        int presupuesto;
        Estudio estudio;

        public Pelicula(string nombre, Persona director, string fechaDeEstreno, string descirpcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaDeEstreno = fechaDeEstreno;
            this.descirpcion = descirpcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
    }
}
