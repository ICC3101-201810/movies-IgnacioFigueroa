using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesLab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BienvenidaForm BienvenidaForm = new BienvenidaForm();
            BienvenidaController bienvenidaController = new BienvenidaController(BienvenidaForm);
            Application.Run(BienvenidaForm);
        }
    }
}
