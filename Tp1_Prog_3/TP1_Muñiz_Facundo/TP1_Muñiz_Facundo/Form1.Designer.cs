namespace TP1_Muñiz_Facundo
{
    partial class vtnPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtripventanas = new System.Windows.Forms.MenuStrip();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeObjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.mtripventanas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtripventanas
            // 
            this.mtripventanas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanasToolStripMenuItem});
            this.mtripventanas.Location = new System.Drawing.Point(0, 0);
            this.mtripventanas.Name = "mtripventanas";
            this.mtripventanas.Size = new System.Drawing.Size(216, 24);
            this.mtripventanas.TabIndex = 3;
            this.mtripventanas.Text = "menuStrip1";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPersonaToolStripMenuItem,
            this.listadoDeObjetosToolStripMenuItem});
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // cargarPersonaToolStripMenuItem
            // 
            this.cargarPersonaToolStripMenuItem.Name = "cargarPersonaToolStripMenuItem";
            this.cargarPersonaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cargarPersonaToolStripMenuItem.Text = "Cargar Persona";
            this.cargarPersonaToolStripMenuItem.Click += new System.EventHandler(this.cargarPersonaToolStripMenuItem_Click);
            // 
            // listadoDeObjetosToolStripMenuItem
            // 
            this.listadoDeObjetosToolStripMenuItem.Name = "listadoDeObjetosToolStripMenuItem";
            this.listadoDeObjetosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listadoDeObjetosToolStripMenuItem.Text = "Listado de Objetos";
            this.listadoDeObjetosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeObjetosToolStripMenuItem_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(79, 67);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(60, 13);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vtnPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 114);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.mtripventanas);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.mtripventanas;
            this.Name = "vtnPrincipal";
            this.mtripventanas.ResumeLayout(false);
            this.mtripventanas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mtripventanas;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeObjetosToolStripMenuItem;
        private System.Windows.Forms.Label lblBienvenido;
    }
}

