using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class PeliculaProductor
    {
        public Pelicula pelicula { get; private set; }
        public List<Persona> productores { get; private set; }

        public PeliculaProductor(Pelicula pelicula, List<Persona> productores)
        {
            this.pelicula = pelicula;
            this.productores = productores;
        }
    }
}
