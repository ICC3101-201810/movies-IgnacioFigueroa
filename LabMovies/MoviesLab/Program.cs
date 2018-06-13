using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MoviesLab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static BienvenidaForm bienvenidaForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bienvenidaForm=new BienvenidaForm();
            BienvenidaController bienvenidaController = new BienvenidaController(bienvenidaForm);
            Application.Run(bienvenidaForm);
            BuscadorForm buscadorForm = new BuscadorForm();
            BuscadorController buscadorController = new BuscadorController(buscadorForm);
            Application.Run(buscadorForm);

        }

        public static void Cerrar()
        {
            bienvenidaForm.Close();
        }
    }
}
