using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public static class BaseDeDatos
    {
        static List<Pelicula> peliculas = new List<Pelicula>();
        static List<Persona> personas= new List<Persona>();
        static List<Estudio> estudios = new List<Estudio>();
        static List<PeliculaActor> peliculaActors = new List<PeliculaActor>();
        static List<PeliculaProductor> peliculaProductors = new List<PeliculaActor>();

        

        public static List<string> BusquedaGeneral(string texto)
        {
            List<string> nombres = new List<string>();
            nombres.AddRange(peliculas.Where(x => x.nombre.ToUpper().Contains(texto)).Select(x => x.nombre).ToList());
            nombres.AddRange(personas.Where(x => x.nombre.ToUpper().Contains(texto)).Select(x => x.nombre).ToList());
            nombres.AddRange(personas.Where(x => x.apellido.ToUpper().Contains(texto)).Select(x => x.nombre).ToList());
            nombres.AddRange(estudios.Where(x => x.nombre.ToUpper().Contains(texto)).Select(x => x.nombre).ToList());

            return nombres;
        }

        public static List<string> BusquedaPeliculas(string texto)
        {
            List<string> nombres = peliculas.Where(x => x.nombre.ToUpper().Contains(texto)).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaActores(string texto)
        {
            List<string> nombres = personas.Where(x => x.nombre.ToUpper().Contains(texto) || x.tipo == Tipo.Actor).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaDirectores(string texto)
        {
            List<string> nombres = personas.Where(x => x.nombre.ToUpper().Contains(texto) || x.tipo == Tipo.Director).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaProductores(string texto)
        {
            List<string> nombres = personas.Where(x => x.nombre.ToUpper().Contains(texto) || x.tipo == Tipo.Productor).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaEstudios(string texto)
        {
            List<string> nombres = estudios.Where(x => x.nombre.ToUpper().Contains(texto)).Select(x => x.nombre).ToList();
            return nombres;
        }



    }
}
