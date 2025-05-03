using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    public partial class ListaContrasenas : Form
    {
        public ListaContrasenas()
        {
            InitializeComponent();
            LoadData();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        public void LoadData()
        {
            try
            {
                DataTable dt = DatabaseContext.ObtenerContrasenas();
                dgListaContrasenas.DataSource = dt;

                // Ocultar columnas no deseadas
                if (dgListaContrasenas.Columns.Contains("Id"))
                    dgListaContrasenas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las contraseñas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
