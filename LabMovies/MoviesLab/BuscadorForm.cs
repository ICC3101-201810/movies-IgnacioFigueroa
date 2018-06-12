using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesLab
{
    public partial class BuscadorForm : Form
    {
        public event EventHandler<BuscadorEventArgs> OnBusquedaEspecifica;
        public event EventHandler<BuscadorEventArgs> OnBusqueda;
        public List<string> listaMostrar;
        public BuscadorForm()
        {
            InitializeComponent();
        }

        private void BuscadorForm_Load(object sender, EventArgs e)
        {

        }

        private void PeliculasB_Click(object sender, EventArgs e)
        {
            BuscadorEventArgs buscadorEventArgs = new BuscadorEventArgs();
            buscadorEventArgs.busqueda = Busqueda.Peliculas;
            buscadorEventArgs.texto = BusquedaTB.Text.ToUpper();
            OnBusquedaEspecifica(this, buscadorEventArgs);
        }

        private void BusquedaTB_TextChanged(object sender, EventArgs e)
        {
            BuscadorEventArgs buscadorEventArgs = new BuscadorEventArgs();
            buscadorEventArgs.texto = BusquedaTB.Text.ToUpper();
            OnBusqueda(this, buscadorEventArgs);
            MostrarLB.DataSource = listaMostrar;
            MostrarLB.Refresh();
        }
    }
}
