using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class PeliculaActor
    {
        Pelicula pelicula;
        Persona actor;

        public PeliculaActor(Pelicula pelicula, Persona actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
}
