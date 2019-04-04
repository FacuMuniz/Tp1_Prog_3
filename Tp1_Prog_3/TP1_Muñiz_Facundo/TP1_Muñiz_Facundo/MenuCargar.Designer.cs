namespace TP1_Muñiz_Facundo
{
    partial class MenuCargar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstilos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEdad2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.GrupoMusica = new System.Windows.Forms.GroupBox();
            this.ckOtros = new System.Windows.Forms.CheckBox();
            this.ckElectronica = new System.Windows.Forms.CheckBox();
            this.ckClasica = new System.Windows.Forms.CheckBox();
            this.ckRock = new System.Windows.Forms.CheckBox();
            this.ckCumbia = new System.Windows.Forms.CheckBox();
            this.ckPop = new System.Windows.Forms.CheckBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.GrupoMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 10);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(36, 46);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(36, 75);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEstilos
            // 
            this.lblEstilos.AutoSize = true;
            this.lblEstilos.Location = new System.Drawing.Point(36, 192);
            this.lblEstilos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstilos.Name = "lblEstilos";
            this.lblEstilos.Size = new System.Drawing.Size(137, 13);
            this.lblEstilos.TabIndex = 3;
            this.lblEstilos.Text = "Estilos Musicales Preferidos";
            this.lblEstilos.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 6);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 42);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(146, 20);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(110, 72);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 7;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(110, 94);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 8;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(39, 297);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(76, 13);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color Preferido";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Verde",
            "Amarillo",
            "Blanco",
            "Negro",
            "Violeta",
            "Naranja"});
            this.comboBox1.Location = new System.Drawing.Point(41, 314);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 117);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 124);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(110, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha De Nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(38, 153);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad";
            // 
            // lblEdad2
            // 
            this.lblEdad2.AutoSize = true;
            this.lblEdad2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdad2.Location = new System.Drawing.Point(90, 153);
            this.lblEdad2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad2.Name = "lblEdad2";
            this.lblEdad2.Size = new System.Drawing.Size(2, 15);
            this.lblEdad2.TabIndex = 16;
            this.lblEdad2.Visible = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(150, 341);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(106, 26);
            this.btnMostrar.TabIndex = 17;
            this.btnMostrar.Text = "Cargar Persona";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // GrupoMusica
            // 
            this.GrupoMusica.Controls.Add(this.ckOtros);
            this.GrupoMusica.Controls.Add(this.ckElectronica);
            this.GrupoMusica.Controls.Add(this.ckClasica);
            this.GrupoMusica.Controls.Add(this.ckRock);
            this.GrupoMusica.Controls.Add(this.ckCumbia);
            this.GrupoMusica.Controls.Add(this.ckPop);
            this.GrupoMusica.Location = new System.Drawing.Point(39, 192);
            this.GrupoMusica.Name = "GrupoMusica";
            this.GrupoMusica.Size = new System.Drawing.Size(306, 86);
            this.GrupoMusica.TabIndex = 32;
            this.GrupoMusica.TabStop = false;
            this.GrupoMusica.Text = "Genero Musical Preferido";
            // 
            // ckOtros
            // 
            this.ckOtros.AutoSize = true;
            this.ckOtros.Location = new System.Drawing.Point(154, 65);
            this.ckOtros.Name = "ckOtros";
            this.ckOtros.Size = new System.Drawing.Size(56, 17);
            this.ckOtros.TabIndex = 19;
            this.ckOtros.Text = "Otro/s";
            this.ckOtros.UseVisualStyleBackColor = true;
            // 
            // ckElectronica
            // 
            this.ckElectronica.AutoSize = true;
            this.ckElectronica.Location = new System.Drawing.Point(27, 65);
            this.ckElectronica.Name = "ckElectronica";
            this.ckElectronica.Size = new System.Drawing.Size(79, 17);
            this.ckElectronica.TabIndex = 18;
            this.ckElectronica.Text = "Electronica";
            this.ckElectronica.UseVisualStyleBackColor = true;
            // 
            // ckClasica
            // 
            this.ckClasica.AutoSize = true;
            this.ckClasica.Location = new System.Drawing.Point(154, 16);
            this.ckClasica.Name = "ckClasica";
            this.ckClasica.Size = new System.Drawing.Size(60, 17);
            this.ckClasica.TabIndex = 16;
            this.ckClasica.Text = "Clásica";
            this.ckClasica.UseVisualStyleBackColor = true;
            // 
            // ckRock
            // 
            this.ckRock.AutoSize = true;
            this.ckRock.Location = new System.Drawing.Point(154, 40);
            this.ckRock.Name = "ckRock";
            this.ckRock.Size = new System.Drawing.Size(52, 17);
            this.ckRock.TabIndex = 14;
            this.ckRock.Text = "Rock";
            this.ckRock.UseVisualStyleBackColor = true;
            // 
            // ckCumbia
            // 
            this.ckCumbia.AutoSize = true;
            this.ckCumbia.Location = new System.Drawing.Point(27, 40);
            this.ckCumbia.Name = "ckCumbia";
            this.ckCumbia.Size = new System.Drawing.Size(61, 17);
            this.ckCumbia.TabIndex = 15;
            this.ckCumbia.Text = "Cumbia";
            this.ckCumbia.UseVisualStyleBackColor = true;
            // 
            // ckPop
            // 
            this.ckPop.AutoSize = true;
            this.ckPop.Location = new System.Drawing.Point(27, 16);
            this.ckPop.Name = "ckPop";
            this.ckPop.Size = new System.Drawing.Size(45, 17);
            this.ckPop.TabIndex = 17;
            this.ckPop.Text = "Pop";
            this.ckPop.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPersonas.Location = new System.Drawing.Point(411, 10);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPersonas.Size = new System.Drawing.Size(513, 324);
            this.dgvPersonas.TabIndex = 33;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(263, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 27);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(411, 340);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 26);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(533, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 27);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // MenuCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 380);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.GrupoMusica);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblEdad2);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEstilos);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MenuCargar";
            this.Text = "X";
            this.GrupoMusica.ResumeLayout(false);
            this.GrupoMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstilos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEdad2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox GrupoMusica;
        private System.Windows.Forms.CheckBox ckClasica;
        private System.Windows.Forms.CheckBox ckRock;
        private System.Windows.Forms.CheckBox ckCumbia;
        private System.Windows.Forms.CheckBox ckPop;
        private System.Windows.Forms.CheckBox ckOtros;
        private System.Windows.Forms.CheckBox ckElectronica;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}