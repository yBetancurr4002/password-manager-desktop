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
    public partial class Form1 : Form
    {
        private List<PasswordEntry> contrasenasGuardadas = new List<PasswordEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar entrada de longitud
            if (!int.TryParse(txtLongitud.Text, out int longitud) || longitud < 4 || longitud > 128)
            {
                MessageBox.Show("Ingrese una longitud válida entre 4 y 128 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar contraseña
            string contrasena = GenerarContrasena(longitud);
            txtContrasenaGenerada.Text = contrasena;
        }

        // Método para generar contraseña segura
        private string GenerarContrasena(int longitud)
        {
            const string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string letrasMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789";
            const string simbolos = ".!@*?/";

            string todosCaracteres = letrasMinusculas + letrasMayusculas + numeros + simbolos;
            char[] contraseña = new char[longitud];
            Random rng = new Random();

            // Asegurar al menos un carácter de cada categoría
            contraseña[0] = letrasMayusculas[rng.Next(letrasMayusculas.Length)];
            contraseña[1] = letrasMinusculas[rng.Next(letrasMinusculas.Length)];
            contraseña[2] = numeros[rng.Next(numeros.Length)];
            contraseña[3] = simbolos[rng.Next(simbolos.Length)];

            // Rellenar el resto con caracteres aleatorios
            for (int i = 4; i < longitud; i++)
            {
                contraseña[i] = todosCaracteres[rng.Next(todosCaracteres.Length)];
            }
            
            // Barajar el array para evitar patrones predecibles
            return new string(contraseña.OrderBy(c => rng.Next()).ToArray());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($" Nombre de la App {txtNombreApp.Text}, Contraseña generada: {txtContrasenaGenerada.Text},  ¿Estás seguro de realizar esta acción?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (resultado == DialogResult.OK)
            {

                if (string.IsNullOrWhiteSpace(txtNombreApp.Text) || string.IsNullOrWhiteSpace(txtContrasenaGenerada.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre de aplicación y genere una contraseña antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DatabaseContext.InsertarContrasena(txtNombreApp.Text, txtContrasenaGenerada.Text))
                {
                    MessageBox.Show("Contraseña guardada exitosamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }

        private class PasswordEntry
        {
            public string NombreApp { get; set; }
            public string Contrasena { get; set; }
        }

        private void btnVerContrasenas_Click(object sender, EventArgs e)
        {
            ListaContrasenas listaContrasenas = new ListaContrasenas();
            listaContrasenas.Show();
            this.Hide();
        }
    }
}
