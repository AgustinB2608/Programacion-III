using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_7
{
    public partial class Ejercicio2_B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblResumen.Text = "<h2>Resumen</h2>";

                //Muestro la zona
                DropDownList ciudades = (DropDownList)PreviousPage.FindControl("ddlCiudades");
                string zona = "<p><strong>Zona:</strong> " + ciudades.SelectedValue + "</p>";

                lblResumen.Text += zona;
            }
        }
    }
}