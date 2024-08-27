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
            HtmlTableRow row1 = (HtmlTableRow)tablaproductos.Rows[1];

            row1.Cells[0].InnerText = txtProducto1.Text;

        }
    }
}