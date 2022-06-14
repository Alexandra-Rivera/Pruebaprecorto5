using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_Hotel
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dgvMostrarTodo.DataSource = null;
            dgvMostrarTodo.DataSource = TablaAimeliDAO.ObtenerAtributos();
        }


        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string nombre = txtNombre.Text;
            string direccion = txtDirección.Text;
            string producto = txtProducto.Text;

            if (TablaAimeliDAO.CrearNuevoAtributo(id, nombre, direccion, producto))
            {
                MessageBox.Show("Datos añadidos éxitosamente", "Conexión con parámetros", MessageBoxButtons.OK,
                    MessageBoxIcon.Information); 
                txtID.Clear();
                txtNombre.Clear();
                txtDirección.Clear();
                txtProducto.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Conexión con parámetros", MessageBoxButtons.OK,
                    MessageBoxIcon.Error); 
            }
        }
        
    }
}