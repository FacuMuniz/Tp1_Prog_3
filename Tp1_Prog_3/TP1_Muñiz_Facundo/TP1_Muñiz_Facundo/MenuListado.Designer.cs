namespace TP1_Muñiz_Facundo
{
    partial class MenuListado
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
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckOriginal = new System.Windows.Forms.CheckedListBox();
            this.ckSecundaria = new System.Windows.Forms.CheckedListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.btnMoverUno = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(160, 23);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(172, 20);
            this.txtLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el Objeto";
            // 
            // ckOriginal
            // 
            this.ckOriginal.CheckOnClick = true;
            this.ckOriginal.FormattingEnabled = true;
            this.ckOriginal.Location = new System.Drawing.Point(12, 88);
            this.ckOriginal.Name = "ckOriginal";
            this.ckOriginal.Size = new System.Drawing.Size(234, 244);
            this.ckOriginal.TabIndex = 2;
            // 
            // ckSecundaria
            // 
            this.ckSecundaria.CheckOnClick = true;
            this.ckSecundaria.FormattingEnabled = true;
            this.ckSecundaria.Location = new System.Drawing.Point(358, 88);
            this.ckSecundaria.Name = "ckSecundaria";
            this.ckSecundaria.Size = new System.Drawing.Size(234, 244);
            this.ckSecundaria.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(338, 21);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 22);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.Location = new System.Drawing.Point(252, 131);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(100, 22);
            this.btnMoverTodos.TabIndex = 5;
            this.btnMoverTodos.Text = ">>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.btnMoverTodos_Click);
            // 
            // btnMoverUno
            // 
            this.btnMoverUno.Location = new System.Drawing.Point(252, 159);
            this.btnMoverUno.Name = "btnMoverUno";
            this.btnMoverUno.Size = new System.Drawing.Size(100, 22);
            this.btnMoverUno.TabIndex = 6;
            this.btnMoverUno.Text = ">";
            this.btnMoverUno.UseVisualStyleBackColor = true;
            this.btnMoverUno.Click += new System.EventHandler(this.btnMoverUno_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(252, 187);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(100, 22);
            this.btnDevolver.TabIndex = 7;
            this.btnDevolver.Text = "<";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(252, 215);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 22);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "***";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // MenuListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 420);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnMoverUno);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.ckSecundaria);
            this.Controls.Add(this.ckOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLista);
            this.Name = "MenuListado";
            this.Text = "MenuListado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ckOriginal;
        private System.Windows.Forms.CheckedListBox ckSecundaria;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMoverTodos;
        private System.Windows.Forms.Button btnMoverUno;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnBorrar;
    }
}