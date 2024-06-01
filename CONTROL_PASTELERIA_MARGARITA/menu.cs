using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CONTROL_PASTELERIA_MARGARITA
{
    public partial class menu : Form
    {
        private static string connectionString = "Server=localhost;Database=pasteleria;User Id=root;Password=";

        public menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            venta abrir = new venta();
            abrir.Show();
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //abre la conexion
                    connection.Open();

                    //se obtiene la informacion de la base de datos
                    string query = "SELECT id_pastel, tipo, sabor, relleno, leyenda, precio FROM pasteles;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Crear instancia del formulario historial
                    historial historialForm = new historial();

                    // Llamar al método en historial para actualizar los datos
                    historialForm.ActualizarDatos(dataTable);

                    // Mostrar el formulario historial
                    historialForm.Show();

                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
