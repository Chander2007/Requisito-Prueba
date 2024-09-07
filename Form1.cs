using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            int cant = cmbNombre.Items.Count;
            for(int i = 0; i < cant; i++)
            {
                string nombre = cmbNombre.Items[i].ToString();
                cmbNombres2.Items.Add(nombre);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }
        public void agregar()
        {
            string nombre = tbNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre) )
            {
                MessageBox.Show("No puede quedar el nombre vacío");
                tbNombre.Focus();
                return;
            }
            cmbNombre.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNombres2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
