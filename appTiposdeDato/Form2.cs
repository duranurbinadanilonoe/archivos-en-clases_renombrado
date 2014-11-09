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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte b1;
            lstNumeros.Items.Add("minimo valor para byte :"+byte.MinValue+"  Maximo valor:"+byte.MaxValue);
            lstNumeros.Items.Add("minimo valor para short :" + short.MinValue + " Maximo valor:" + short.MaxValue);
            lstNumeros.Items.Add("minimo valor para int :" + int.MinValue + " Maximo valor:" + int.MaxValue);

            // EN JAVA SERIA: string cadena = " c:\\\"documentos\"";
            // EN NET:
            string cadena2 = @"c:\documentos";
            this.Text = cadena2;
        }
    }
}
