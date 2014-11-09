namespace app004
{
    partial class miformulario3
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificaFondo = new System.Windows.Forms.Button();
            this.btnQuitaMinimiza = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnQuitaControles = new System.Windows.Forms.Button();
            this.btnActivaControles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificaFondo
            // 
            this.btnModificaFondo.AutoSize = true;
            this.btnModificaFondo.Location = new System.Drawing.Point(365, 21);
            this.btnModificaFondo.Name = "btnModificaFondo";
            this.btnModificaFondo.Size = new System.Drawing.Size(166, 23);
            this.btnModificaFondo.TabIndex = 0;
            this.btnModificaFondo.Text = "modifica &formato";
            this.btnModificaFondo.UseVisualStyleBackColor = true;
            this.btnModificaFondo.Click += new System.EventHandler(this.btnModificaFondo_Click);
            // 
            // btnQuitaMinimiza
            // 
            this.btnQuitaMinimiza.Location = new System.Drawing.Point(365, 134);
            this.btnQuitaMinimiza.Name = "btnQuitaMinimiza";
            this.btnQuitaMinimiza.Size = new System.Drawing.Size(166, 23);
            this.btnQuitaMinimiza.TabIndex = 1;
            this.btnQuitaMinimiza.Text = "quita &minimiza";
            this.btnQuitaMinimiza.UseVisualStyleBackColor = true;
            this.btnQuitaMinimiza.Click += new System.EventHandler(this.btnQuitaMinimiza_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(456, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnQuitaControles
            // 
            this.btnQuitaControles.Location = new System.Drawing.Point(365, 163);
            this.btnQuitaControles.Name = "btnQuitaControles";
            this.btnQuitaControles.Size = new System.Drawing.Size(166, 23);
            this.btnQuitaControles.TabIndex = 1;
            this.btnQuitaControles.Text = "quita &controles";
            this.btnQuitaControles.UseVisualStyleBackColor = true;
            this.btnQuitaControles.Click += new System.EventHandler(this.btnQuitaControles_Click);
            // 
            // btnActivaControles
            // 
            this.btnActivaControles.Location = new System.Drawing.Point(365, 192);
            this.btnActivaControles.Name = "btnActivaControles";
            this.btnActivaControles.Size = new System.Drawing.Size(166, 23);
            this.btnActivaControles.TabIndex = 1;
            this.btnActivaControles.Text = "Actica c&ontroles";
            this.btnActivaControles.UseVisualStyleBackColor = true;
            this.btnActivaControles.Click += new System.EventHandler(this.btnActivaControles_Click);
            // 
            // miformulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 421);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActivaControles);
            this.Controls.Add(this.btnQuitaControles);
            this.Controls.Add(this.btnQuitaMinimiza);
            this.Controls.Add(this.btnModificaFondo);
            this.Name = "miformulario3";
            this.Text = "trabajo con propiedades";
            this.Load += new System.EventHandler(this.miformulario3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificaFondo;
        private System.Windows.Forms.Button btnQuitaMinimiza;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnQuitaControles;
        private System.Windows.Forms.Button btnActivaControles;
    }
}

