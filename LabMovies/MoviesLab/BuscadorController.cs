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
        }

        public void BuscadorForm_OnBusquedaEspecifica(object sender, BuscadorEventArgs e)
        {
            if (e.busqueda == Busqueda.Actores)
            {
                buscadorForm.listaMostrar = BaseDeDatos.BusquedaActores(e.texto);
            }

            else if(e.busqueda == Busqueda.Directores)
            {
                buscadorForm.listaMostrar = BaseDeDatos.BusquedaDirectores(e.texto);
            }

            else if(e.busqueda == Busqueda.Estudios)
            {
                buscadorForm.listaMostrar = BaseDeDatos.BusquedaEstudios(e.texto);
            }

            else if(e.busqueda == Busqueda.Peliculas)
            {
                buscadorForm.listaMostrar = BaseDeDatos.BusquedaPeliculas(e.texto);
            }

            else if(e.busqueda == Busqueda.Productores)
            {
                buscadorForm.listaMostrar = BaseDeDatos.BusquedaProductores(e.texto);
            }
        }

        public void BuscadorForm_OnBusqueda(object sender, BuscadorEventArgs e)
        {
            buscadorForm.listaMostrar = BaseDeDatos.BusquedaGeneral(e.texto);
        }
    }
}
