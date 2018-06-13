using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class PeliculaActor
    {
        public Pelicula pelicula { get; private set; }
        public List<Persona> actores { get; private set; }

        public PeliculaActor(Pelicula pelicula, List<Persona> actores)
        {
            this.pelicula = pelicula;
            this.actores = actores;
        }
    }
}
