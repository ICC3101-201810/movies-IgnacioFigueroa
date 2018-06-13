using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MoviesLab
{
    public partial class BuscadorForm : Form
    {
        public event EventHandler<BuscadorEventArgs> OnBusquedaEspecifica;
        public event EventHandler<BuscadorEventArgs> OnBusqueda;
        public event EventHandler<BuscadorEventArgs> OnMostrarInfo;
        public List<string> listaMostrarBusqueda;
        public List<string> listaMostrarInformacion ;
        public Busqueda parametro;

        public BuscadorForm()
        {
            InitializeComponent();
            MostrarLB.Enabled = false;
            InformacionLB.Hide();
            InformacionLB.Enabled = false;
            listaMostrarBusqueda = new List<string>();
            listaMostrarInformacion = new List<string>();
        }

        private void ClickBoton(Busqueda busqueda)
        {
            BuscadorEventArgs buscadorEventArgs = new BuscadorEventArgs();
            buscadorEventArgs.busqueda = busqueda;
            buscadorEventArgs.texto = BusquedaTB.Text.ToUpper();
            OnBusquedaEspecifica(this, buscadorEventArgs);
            MostrarLB.DataSource = listaMostrarBusqueda;
            MostrarLB.Refresh();
            MostrarLB.Enabled = true;
            parametro = busqueda;
        }

        private void BuscadorForm_Load(object sender, EventArgs e)
        {
        }

        private void PeliculasB_Click(object sender, EventArgs e)
        {
            ClickBoton(Busqueda.Peliculas);

        }


        private void BusquedaTB_TextChanged(object sender, EventArgs e)
        {
            listaMostrarBusqueda.Clear();
            MostrarLB.DataSource = new List<string>();
            MostrarLB.Enabled = false;
            InformacionLB.Hide();
            if (BusquedaTB.Text.Length < 3) return;
            BuscadorEventArgs buscadorEventArgs = new BuscadorEventArgs();
            buscadorEventArgs.texto = BusquedaTB.Text.ToUpper();
            OnBusqueda(this, buscadorEventArgs);
            MostrarLB.DataSource = listaMostrarBusqueda;
            MostrarLB.Refresh();

                       
        }

        private void ActoresB_Click(object sender, EventArgs e)
        {
            ClickBoton(Busqueda.Actores);

        }

        private void DirectoresB_Click(object sender, EventArgs e)
        {
            ClickBoton(Busqueda.Directores);

        }

        private void ProductoresB_Click(object sender, EventArgs e)
        {
            ClickBoton(Busqueda.Productores);

        }

        private void EstudiosB_Click(object sender, EventArgs e)
        {
            ClickBoton(Busqueda.Estudios);

        }

        private void MostrarLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscadorEventArgs buscadorEventArgs = new BuscadorEventArgs();
            buscadorEventArgs.texto = ((string)MostrarLB.SelectedItem).ToUpper();
            buscadorEventArgs.busqueda = parametro;
            OnMostrarInfo(this, buscadorEventArgs);
            InformacionLB.DataSource = listaMostrarInformacion;

        }

        private void InformacionVB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuscadorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BaseDeDatos.SerializeAll();
            Environment.Exit(0);
        }

        private void SalirB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InformacionLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarLB_Click(object sender, EventArgs e)
        {
            InformacionLB.Show();
        }
    }
}
