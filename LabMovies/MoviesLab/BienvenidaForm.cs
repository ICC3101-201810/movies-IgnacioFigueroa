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
    public partial class BienvenidaForm : Form
    {
        public event EventHandler OnInicio;
        public BienvenidaForm()
        {
            InitializeComponent();
        }
    }
}
