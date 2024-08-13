namespace TP1_Grupo_7
{
    partial class Ejercicio1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNOMBRES = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.lbNOMBRES = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNOMBRES
            // 
            this.lblNOMBRES.AutoSize = true;
            this.lblNOMBRES.Location = new System.Drawing.Point(94, 58);
            this.lblNOMBRES.Name = "lblNOMBRES";
            this.lblNOMBRES.Size = new System.Drawing.Size(95, 13);
            this.lblNOMBRES.TabIndex = 0;
            this.lblNOMBRES.Text = "Ingrese un nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(209, 55);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.txtNOMBRE.TabIndex = 1;
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Location = new System.Drawing.Point(350, 52);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(75, 23);
            this.btnACEPTAR.TabIndex = 2;
            this.btnACEPTAR.Text = "button1";
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // lbNOMBRES
            // 
            this.lbNOMBRES.FormattingEnabled = true;
            this.lbNOMBRES.Location = new System.Drawing.Point(97, 150);
            this.lbNOMBRES.Name = "lbNOMBRES";
            this.lbNOMBRES.Size = new System.Drawing.Size(120, 95);
            this.lbNOMBRES.TabIndex = 3;
            // 
            // Ejercicio1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNOMBRES);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.lblNOMBRES);
            this.Name = "Ejercicio1Form";
            this.Text = "Ejercicio1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNOMBRES;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.ListBox lbNOMBRES;
    }
}