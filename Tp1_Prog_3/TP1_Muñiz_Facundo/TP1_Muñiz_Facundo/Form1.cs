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
    public partial class vtnPrincipal : Form
    {
        public vtnPrincipal()
        {
            InitializeComponent();
        }

      

        private void cargarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCargar menuCargar = new MenuCargar();
            menuCargar.Show();
        }

        private void listadoDeObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuListado menuListado = new MenuListado();
            menuListado.Show();
        }
    }
}
