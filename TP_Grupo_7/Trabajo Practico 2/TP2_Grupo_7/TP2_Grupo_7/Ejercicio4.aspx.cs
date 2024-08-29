using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_7
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            string UsuarioValido = "claudio";
            string ClaveValida = "casas";

            if(TextBox1.Text == UsuarioValido && TextBox2.Text == ClaveValida)
            {
                ///Redirigir a pagina de usuario valido
            }
            else
            {
                ///Redirigir a pagina de usuario invalido
            }

        }
    }
}