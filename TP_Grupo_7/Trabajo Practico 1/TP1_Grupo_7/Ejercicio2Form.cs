using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TP1_Grupo_7
{
    public partial class Ejercicio2Form : Form
    {
        public Ejercicio2Form()
        {
            InitializeComponent();
        }

        private void GpbNombreYApellido_Enter(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim() != "")
            {
                
            }
            else
            {
                MessageBox.Show("El nombre ingresado no es valido, el campo no debe estar vacio");
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string Aborrar = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(Aborrar);
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento", "Atencion");
            }
        }
    }
}
