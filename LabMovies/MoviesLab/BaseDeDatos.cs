using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MoviesLab
{
    [Serializable()]
    public static class BaseDeDatos
    {
        static List<Pelicula> peliculas = new List<Pelicula> { new Pelicula("prueba", new Persona("nombre", "apellido", "fecha", "biografia", Tipo.Director), "estreno", "descripcion",1000, new Estudio("nombre estudio", "direccion", "apertura")), new Pelicula("pruebo", new Persona("nombre", "apellido", "fecha", "biografia", Tipo.Director), "estreno", "descripcion", 1000, new Estudio("nombre estudio", "direccion", "apertura")) };
        static List<Persona> personas= new List<Persona>();
        static List<Estudio> estudios = new List<Estudio>();
        static List<PeliculaActor> peliculaActors = new List<PeliculaActor>();
        static List<PeliculaProductor> peliculaProductors = new List<PeliculaProductor>();
        static List<Critica> criticas = new List<Critica>();

        

        public static List<string> BusquedaGeneral(string texto)
        {
            List<string> nombres = new List<string>();
            List<string>peliculasNombres = peliculas.Where(x => x.nombre.ToUpper().Contains(texto) || x.descripcion.ToUpper().Contains(texto)).Select(x => x.nombre).ToList();
            List<string> personasNombres = personas.Where(x => x.nombre.ToUpper().Contains(texto) || x.apellido.ToUpper().Contains(texto)).Select(x => x.nombre).ToList();
            List<string> estudiosNombres = estudios.Where(x => x.nombre.ToUpper().Contains(texto) || x.direccion.ToUpper().Contains(texto)).Select(x => x.nombre).ToList();
            nombres.AddRange(peliculasNombres);
            nombres.AddRange(personasNombres);
            nombres.AddRange(estudiosNombres);

            return nombres;
        }

        public static List<string> BusquedaPeliculas(string texto)
        {
            List<string> nombres = peliculas.Where(x => x.nombre.ToUpper().Contains(texto)).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaActores(string texto)
        {
            List<string> nombres = personas.Where(x => x.nombre.ToUpper().Contains(texto) && x.tipo == Tipo.Actor).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaDirectores(string texto)
        {
            List<string> nombres = personas.Where(x => x.nombre.ToUpper().Contains(texto) && x.tipo == Tipo.Director).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaProductores(string texto)
        {
            List<string> nombres = personas.Where(x => x.nombre.ToUpper().Contains(texto) && x.tipo == Tipo.Productor).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> BusquedaEstudios(string texto)
        {
            List<string> nombres = estudios.Where(x => x.nombre.ToUpper().Contains(texto)).Select(x => x.nombre).ToList();
            return nombres;
        }

        public static List<string> InformacionBasicaPersona(Persona persona)
        {
            List<string> informacion = new List<string>();
            informacion.Add($"Nombre: {persona.nombre}");
            informacion.Add($"Apellido: {persona.apellido}");
            informacion.Add($"Fecha de Nacimiento: {persona.fechadeNacimiento}");
            informacion.Add($"Biografia: {persona.biografia}");
            return informacion;
        }

        public static List<string> InfoPelicula(string texto)
        {
            List<string> informacion = new List<string>();
            Pelicula pelicula = peliculas.Where(x => x.nombre.ToUpper() == texto).First();
            informacion.Add($"Nombre: {pelicula.nombre}");
            informacion.Add($"Director: {pelicula.director.nombre} {pelicula.director.apellido}");
            informacion.Add($"Fecha de Estreno: {pelicula.fechaDeEstreno}");
            informacion.Add($"Descripcion: {pelicula.descripcion}");
            informacion.Add($"Presupuesto: {pelicula.presupuesto}");
            informacion.Add($"Estudio: {pelicula.estudio.nombre}");
            informacion.Add("Actores: ");
            List<PeliculaActor> peliculasActor = peliculaActors.Where(x => x.pelicula == pelicula).ToList();
            foreach(PeliculaActor peli in peliculasActor)
            {
                foreach(Persona persona in peli.actores)
                {
                    informacion.Add(persona.nombre + " " + persona.apellido);
                }
            }
            informacion.Add("Productores");
            List<PeliculaProductor> peliculasProductor = peliculaProductors.Where(x => x.pelicula == pelicula).ToList();
            foreach(PeliculaProductor peli in peliculasProductor)
            {
                foreach (Persona persona in peli.productores)
                {
                    informacion.Add(persona.nombre +" "+persona.apellido);
                }
            }

            List<Critica> peliculasCriticadas = criticas.Where(x => x.pelicula == pelicula).ToList();
            if (peliculasCriticadas.Count > 0)
            {
                informacion.Add("Critica: ");
                informacion.Add(peliculasCriticadas[0].mensaje);
            }
            return informacion;

            
        }

        public static List<string> InfoActor(string texto)
        {
            List<string> informacion = new List<string>();
            Persona persona = personas.Where(x => x.nombre.ToUpper() == texto || x.apellido.ToUpper() == texto).First();
            informacion.AddRange(InformacionBasicaPersona(persona));
            informacion.Add("Peliculas en las que aparece: ");
            informacion.AddRange(peliculaActors.Where(x => x.actores.Contains(persona)).Select(x => x.pelicula.nombre));
            return informacion;
        }

        public static List<string> InfoDirector(string texto)
        {
            List<string> informacion = new List<string>();
            Persona persona = personas.Where(x => x.nombre.ToUpper() == texto || x.apellido.ToUpper()==texto).First();
            informacion.AddRange(InformacionBasicaPersona(persona));
            informacion.Add("Peliculas que dirige :");
            informacion.AddRange(peliculas.Where(x => x.director.nombre.ToUpper() == texto).Select(x => x.nombre));
            return informacion;
        }

        public static List<string> InfoProductor(string texto)
        {
            List<string> informacion = new List<string>();
            Persona persona = personas.Where(x => x.nombre.ToUpper() == texto || x.apellido.ToUpper() == texto).First();
            informacion.AddRange(InformacionBasicaPersona(persona));
            informacion.Add("Peliculas que produce: ");
            informacion.AddRange(peliculaProductors.Where(x => x.productores.Contains(persona)).Select(x => x.pelicula.nombre));
            return informacion;
        }

        public static List<string> InfoEstudio(string texto)
        {
            List<string> informacion = new List<string>();
            Estudio estudio = estudios.Where(x => x.nombre.ToUpper() == texto).First();
            informacion.Add($"Nombre: {estudio.nombre}");
            informacion.Add($"Direccion: {estudio.direccion}");
            informacion.Add($"Fecha de Apertura: {estudio.fechaApertura}");
            informacion.Add("Peliculas: ");
            informacion.AddRange(peliculas.Where(x => x.estudio == estudio).Select(x => x.nombre));
            return informacion;
        }

        public static void SerializeAll()
        {
            try
            {
                using (Stream stream = File.Open("../../archivos/peliculasData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter peliculasData = new BinaryFormatter();
                    peliculasData.Serialize(stream, peliculas);
                }
            }
            catch (IOException) { }

            try
            {
                using (Stream stream = File.Open("../../archivos/personasData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter personasData = new BinaryFormatter();
                    personasData.Serialize(stream, personas);
                }
            }
            catch (IOException) { }

            try
            {
                using (Stream stream = File.Open("../../archivos/estudiosData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter estudiosData = new BinaryFormatter();
                    estudiosData.Serialize(stream, estudios);
                }
            }
            catch (IOException) { }

            try
            {
                using (Stream stream = File.Open("../../archivos/peliculasActorsData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter peliculasActorsData = new BinaryFormatter();
                    peliculasActorsData.Serialize(stream, peliculaActors);
                }
            }
            catch (IOException) { }

            try
            {
                using (Stream stream = File.Open("../../archivos/peliculasProductorsData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter peliculasProductorsData = new BinaryFormatter();
                    peliculasProductorsData.Serialize(stream, peliculaProductors);
                }
            }
            catch (IOException) { }
        }



    }
}
