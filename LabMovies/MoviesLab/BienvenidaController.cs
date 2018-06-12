using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    class BienvenidaController
    {
        BienvenidaForm bienvenidaForm;

        public BienvenidaController(BienvenidaForm bienvenidaForm)
        {
            this.bienvenidaForm = bienvenidaForm;
            bienvenidaForm.OnInicio += BienvenidaForm_OnInicio;
        }

        public void BienvenidaForm_OnInicio(object sender, EventArgs e)
        {
            
        }


    }
}
