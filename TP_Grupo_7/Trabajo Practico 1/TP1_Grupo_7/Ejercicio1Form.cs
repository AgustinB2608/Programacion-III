﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Grupo_7
{
    public partial class Ejercicio1Form : Form
    {
        public Ejercicio1Form()
        {
            InitializeComponent();
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            lbNOMBRES.Items.Add(txtNOMBRE.Text);
        }
    }
}
