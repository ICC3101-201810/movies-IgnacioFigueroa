using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    class BuscadorController
    {
        BuscadorForm buscadorForm;

        public BuscadorController(BuscadorForm buscadorForm)
        {
            this.buscadorForm = buscadorForm;
            buscadorForm.OnBusquedaEspecifica += BuscadorForm_OnBusquedaEspecifica;
            buscadorForm.OnBusqueda += BuscadorForm_OnBusqueda;
            buscadorForm.OnMostrarInfo += BuscadorForm_OnMostrarInfo;
        }

        public void BuscadorForm_OnBusquedaEspecifica(object sender, BuscadorEventArgs e)
        {
            if (e.busqueda == Busqueda.Actores)
            {
                buscadorForm.listaMostrarBusqueda = BaseDeDatos.BusquedaActores(e.texto);

            }

            else if(e.busqueda == Busqueda.Directores)
            {
                buscadorForm.listaMostrarBusqueda = BaseDeDatos.BusquedaDirectores(e.texto);
            }

            else if(e.busqueda == Busqueda.Estudios)
            {
                buscadorForm.listaMostrarBusqueda = BaseDeDatos.BusquedaEstudios(e.texto);
            }

            else if(e.busqueda == Busqueda.Peliculas)
            {
                buscadorForm.listaMostrarBusqueda = BaseDeDatos.BusquedaPeliculas(e.texto);
            }

            else if(e.busqueda == Busqueda.Productores)
            {
                buscadorForm.listaMostrarBusqueda =BaseDeDatos.BusquedaProductores(e.texto);
            }
        }

        public void BuscadorForm_OnBusqueda(object sender, BuscadorEventArgs e)
        {

            int contador = 0;
            foreach(string s in BaseDeDatos.BusquedaGeneral(e.texto))
            {
                if (contador == 50) break;
                buscadorForm.listaMostrarBusqueda.Add(s);
                contador++;
            }

        }

        public void BuscadorForm_OnMostrarInfo(object sender, BuscadorEventArgs e)
        {
            if(e.busqueda == Busqueda.Actores)
            {
                buscadorForm.listaMostrarInformacion = BaseDeDatos.InfoActor(e.texto);
            }

            if (e.busqueda == Busqueda.Peliculas)
            {
                buscadorForm.listaMostrarInformacion = BaseDeDatos.InfoPelicula(e.texto);
            }

            if (e.busqueda == Busqueda.Directores)
            {
                buscadorForm.listaMostrarInformacion = BaseDeDatos.InfoDirector(e.texto);
            }

            if (e.busqueda == Busqueda.Productores)
            {
                buscadorForm.listaMostrarInformacion = BaseDeDatos.InfoProductor(e.texto);
            }

            if (e.busqueda == Busqueda.Estudios)
            {
                buscadorForm.listaMostrarInformacion = BaseDeDatos.InfoEstudio(e.texto);
            }
        }
    }
    
}
