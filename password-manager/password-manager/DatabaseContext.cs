using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;


namespace password_manager
{
    public class DatabaseContext
    {
        public DatabaseContext() { }
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Método para insertar contraseña
        public static bool InsertarContrasena(string nombreApp, string contrasena)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    string query = "INSERT INTO ContrasenasGeneradas (NombreApp, Contrasena) VALUES (@NombreApp, @Contrasena)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreApp", nombreApp);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Método para obtener todas las contraseñas
        public static DataTable ObtenerContrasenas()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    string query = "SELECT Id, NombreApp, Contrasena, FechaGeneracion FROM ContrasenasGeneradas";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    conn.Open();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DataTable();
                }
            }
        }
    }
}
