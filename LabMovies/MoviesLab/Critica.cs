using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class Critica
    {
        public Pelicula pelicula { get; private set; }
        public string mensaje { get; private set; }

        public Critica(Pelicula pelicula, string mensaje)
        {
            this.pelicula = pelicula;
            this.mensaje = mensaje;
        }
    }
}
