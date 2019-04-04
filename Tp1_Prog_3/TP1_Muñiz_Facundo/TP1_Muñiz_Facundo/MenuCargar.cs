using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Muñiz_Facundo
{
    public partial class MenuCargar : Form
    {

        List<Persona> ds = new List<Persona>();
        int cont = 1;
        int aux = 0;

        public MenuCargar()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int edad = DateTime.Now.Year - dateTimePicker1.Value.Year;
            string Edad;
            Edad = edad.ToString();

            lblEdad2.Text = Edad;
            lblEdad2.Visible = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbFemenino.Checked == false)
            {
                if (rdbMasculino.Checked == true)
                {
                    if (txtNombre.Text == "" || txtApellido.Text == "")
                    {
                        txtNombre.BackColor = Color.Red;
                        txtApellido.BackColor = Color.Red;
                    }
                    else
                    {
                        
                        var persona = new Persona();
                        persona.id = cont;
                        persona.Nombre = txtNombre.Text;
                        persona.Apellido = txtApellido.Text;
                        persona.FechaNacimiento = dateTimePicker1.Value.ToString();
                        persona.Edad = lblEdad2.Text;
                        if (rdbFemenino.Checked == true) persona.Sexo = "Femenino";
                        else persona.Sexo = "Masculino";
                        if (ckPop.Checked == true) persona.Musica = "Pop";
                        if (ckClasica.Checked == true) persona.Musica = persona.Musica + "  " + "Clasica";
                        if (ckCumbia.Checked == true) persona.Musica = persona.Musica + "  " + "Cumbia";
                        if (ckRock.Checked == true) persona.Musica = persona.Musica + "  " + "Rock";
                        if (ckElectronica.Checked == true) persona.Musica = persona.Musica + "  " + "Electronica";
                        if (ckOtros.Checked == true) persona.Musica = persona.Musica + "  " + "Otros";
                        persona.Color_Favorito = comboBox1.SelectedItem.ToString();

                        if (persona.id <= ds.Count)
                        {
                            var itemasacar = ds.Single(r => r.id == persona.id);
                            ds.Remove(itemasacar);
                        }


                        ds.Add(persona);


                        dgvPersonas.DataSource = ds;
                        dgvPersonas.Refresh();
                        cont = ds.Count+1;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un sexo por favor");
                }

            }
            else
            {



                if (txtNombre.Text == "" || txtApellido.Text == "" || lblEdad2.Text == "")
                {
                    MessageBox.Show("Ingrese Nombre, Apellido y Edad por favor");
                }
                else
                {
                    var persona = new Persona();
                    persona.id = cont;
                    persona.Nombre = txtNombre.Text;
                    persona.Apellido = txtApellido.Text;
                    persona.FechaNacimiento = dateTimePicker1.Value.ToString();
                    persona.Edad = lblEdad2.Text;
                    if (rdbFemenino.Checked == true) persona.Sexo = "Femenino";
                    else persona.Sexo = "Masculino";
                    if (ckPop.Checked == true) persona.Musica = "Pop";
                    if (ckClasica.Checked == true) persona.Musica = persona.Musica + "  " + "Clasica";
                    if (ckCumbia.Checked == true) persona.Musica = persona.Musica + "  " + "Cumbia";
                    if (ckRock.Checked == true) persona.Musica = persona.Musica + "  " + "Rock";
                    if (ckElectronica.Checked == true) persona.Musica = persona.Musica + "  " + "Electronica";
                    if (ckOtros.Checked == true) persona.Musica = persona.Musica + "  " + "Otros";
                    persona.Color_Favorito = comboBox1.SelectedItem.ToString();

                    if (persona.id <= ds.Count)
                    {
                        var itemasacar = ds.Single(r => r.id == persona.id);
                        ds.Remove(itemasacar);
                    }

                    ds.Add(persona);

                    var bindinglist = new BindingList<Persona>(ds);

                    var source = new BindingSource(bindinglist, null);

                    dgvPersonas.DataSource = source;
                    cont = ds.Count+1;
                }

            }


        }









        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            lblEdad2.Text = "";
            rdbMasculino.Checked = false;
            rdbFemenino.Checked = false;
            ckPop.Checked = false;
            ckClasica.Checked = false;
            ckRock.Checked = false;
            ckCumbia.Checked = false;
            ckElectronica.Checked = false;
            ckOtros.Checked = false;
            comboBox1.SelectedItem = false;
            cont = ds.Count+1;
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count==1)
            { 
                var persona = new Persona();

                foreach(DataGridViewRow r in dgvPersonas.SelectedRows)
                {
                    persona.id=(int.Parse(r.Cells[0].Value.ToString()));
                    persona.Apellido = (r.Cells[1].Value.ToString());
                    persona.Nombre = (r.Cells[2].Value.ToString());
                    persona.FechaNacimiento = (r.Cells[3].Value.ToString());
                    persona.Edad = (r.Cells[4].Value.ToString());
                    persona.Sexo= (r.Cells[5].Value.ToString());
                    persona.Musica= (r.Cells[6].Value.ToString());
                    persona.Color_Favorito = (r.Cells[7].Value.ToString());
                }
                var itemasacar = ds.Single(r => r.id == persona.id);
                ds.Remove(itemasacar);
                
                var bindinglist = new BindingList<Persona>(ds);

                var source = new BindingSource(bindinglist, null);

                dgvPersonas.DataSource = source;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count == 1)
            {
                var persona = new Persona();

                foreach (DataGridViewRow r in dgvPersonas.SelectedRows)
                {
                    persona.id = (int.Parse(r.Cells[0].Value.ToString()));
                    persona.Apellido = (r.Cells[1].Value.ToString());
                    persona.Nombre = (r.Cells[2].Value.ToString());
                    persona.FechaNacimiento = (r.Cells[3].Value.ToString());
                    persona.Edad = (r.Cells[4].Value.ToString());
                    persona.Sexo = (r.Cells[5].Value.ToString());
                    persona.Musica = (r.Cells[6].Value.ToString());
                    persona.Color_Favorito = (r.Cells[7].Value.ToString());
                }
                cont = persona.id;
                txtNombre.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;
                lblEdad2.Text = persona.Edad;
                if (persona.Sexo == "Masculino") rdbMasculino.Checked = true;
                else rdbFemenino.Checked = true;
                
                if(persona.Musica.Contains("Pop")) ckPop.Checked = true;
                if (persona.Musica.Contains("Clasica")) ckClasica.Checked = true;
                if (persona.Musica.Contains("Rock")) ckRock.Checked = true;
                if (persona.Musica.Contains("Electronica")) ckElectronica.Checked = true;
                if (persona.Musica.Contains("Cumbia")) ckCumbia.Checked = true;
                if (persona.Musica.Contains("Otros")) ckOtros.Checked = true;

                comboBox1.SelectedItem = persona.Color_Favorito;

            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

    }
}
