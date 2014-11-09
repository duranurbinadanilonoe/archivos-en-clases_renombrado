using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace app004
{
    public partial class miformulario3 : Form
    {
        public miformulario3()
        {
            InitializeComponent();
        }

        private void btnModificaFondo_Click(object sender, EventArgs e)
        {
            // cambia el formato ...
            this.BackColor= Color.Chocolate;

        }

        private void miformulario3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            // para cerrar toda la aplicacion: Application.Exit();

        }
        public void fncCambiaColor()
        {
            String col = this.BackColor.Name;
            
            if (col.Equals("yelow"))
            {
                if (col.Equals("cyen"))
                {
                    col = "red";
                }  
                else
                {
                    col = "yelow";
                }
            }
            else
            {
                col = "cyan";
            }


        }

        private void btnQuitaMinimiza_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
        }

        private void btnQuitaControles_Click(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnActivaControles_Click(object sender, EventArgs e)
        {
            this.ControlBox = true;
        }

      


    }
}
