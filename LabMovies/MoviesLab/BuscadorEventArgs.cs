using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public enum Busqueda { Peliculas, Actores, Directores, Productores, Estudios}
    public class BuscadorEventArgs : EventArgs
    {
        public Busqueda busqueda;
        public string texto;
    }
}
