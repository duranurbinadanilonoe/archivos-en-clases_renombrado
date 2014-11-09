using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appTiposdeDato
{
    public partial class Form1 : Form
    {
        private ListBox lstNumeros;
        private Button btnNumeros;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(129, 57);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(129, 147);
            this.lstNumeros.TabIndex = 3;
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(26, 57);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(75, 23);
            this.btnNumeros.TabIndex = 2;
            this.btnNumeros.Text = "button1";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnNumeros);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            byte b1;
            lstNumeros.Items.Add("minimo valor para byte :" + byte.MinValue + "  Maximo valor:" + byte.MaxValue);
            lstNumeros.Items.Add("minimo valor para short :" + short.MinValue + " Maximo valor:" + short.MaxValue);
            lstNumeros.Items.Add("minimo valor para int :" + int.MinValue + " Maximo valor:" + int.MaxValue);

            // EN JAVA SERIA: string cadena = " c:\\\"documentos\"";
            // EN NET:
            string cadena2 = @"c:\documentos";
            this.Text = cadena2;
        }
    }
}
