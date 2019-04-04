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
    public partial class MenuListado : Form
    {
        public MenuListado()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ckOriginal.Items.Add(txtLista.Text);
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ckOriginal.Items.Count; i++)

                ckOriginal.SetItemChecked(i, true);
            if (ckOriginal.CheckedItems.Count > 0)
            {
                foreach (string item in ckOriginal.CheckedItems)
                {
                    ckSecundaria.Items.Add(item.ToString());
                }
                ckOriginal.Items.Clear();
            }
        }

        private void btnMoverUno_Click(object sender, EventArgs e)
        {
            
            if (ckOriginal.CheckedItems.Count == 1)
            {
                if (VerificarItem(ckOriginal.CheckedItems[0].ToString()) == 0)
                {
                    foreach (string item in ckOriginal.CheckedItems)
                    {
                        ckSecundaria.Items.Add(item.ToString());
                    }
                    ckOriginal.Items.Remove(ckOriginal.SelectedItem);
                    for (int i = 0; i < ckOriginal.Items.Count; i++)
                        ckOriginal.SetItemChecked(i, false);
                }
                else MessageBox.Show("Elemento repetido. Por favor seleccione otro o elemine el objeto de la grilla correspondiente");
                    
            }
        }
        
        private int VerificarItem(string I)
        {
            int cont = 0;
            foreach (string item in ckSecundaria.Items)
            {
                if (item == I) cont++;
            }
            return cont;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

            if (ckSecundaria.CheckedItems.Count == 1)
            {
                foreach (string item in ckSecundaria.CheckedItems)
                {
                    ckOriginal.Items.Add(item.ToString());
                }
                ckSecundaria.Items.Remove(ckSecundaria.SelectedItem);
                for (int i = 0; i < ckSecundaria.Items.Count; i++)
                    ckSecundaria.SetItemChecked(i, false);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ckSecundaria.CheckedItems.Count == 1)
            {
                if (ckSecundaria.SelectedItem != null)
                {
                    ckSecundaria.Items.Remove(ckSecundaria.SelectedItem);
                }
                for (int i = 0; i < ckSecundaria.Items.Count; i++)
                    ckSecundaria.SetItemChecked(i, false);
            }
            
        }
    }
}
