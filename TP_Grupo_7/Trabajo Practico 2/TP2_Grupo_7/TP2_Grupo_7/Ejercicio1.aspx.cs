using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TP2_Grupo_7
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            string ProductoUno = txtProducto1.Text;
            string tabla= "<table>";

            tabla += "<tr style= 'font-weight: bold; color: black;'>";
            tabla += "<td> Producto </td>";
            tabla += "<td> Cantidad </td>";
            tabla += "</tr>";

            tabla += "<tr>";
            tabla += "<td>" + ProductoUno.ToString() + "<td/>";
            tabla += "<td>" + " " + "</td>";
            tabla += "</tr>";

            Label1.Text = tabla;

        }
    }
}