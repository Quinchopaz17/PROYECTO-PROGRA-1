using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CONTROL_PASTELERIA_MARGARITA
{
    public partial class historial : Form
    {
        private static string connectionString = "Server=localhost;Database=pasteleria;User Id=root;Password=";

        public historial()
        {
            InitializeComponent();
            // Llamar a MostrarDatos cuando se cargue el formulario
            this.Load += new EventHandler(historial_Load);
        }

        // Método para actualizar el DataGridView con los datos de la base de datos
        public void ActualizarDatos(DataTable dataTable)
        {
            dataGridView2.DataSource = dataTable;
        }

        // Evento para manejar la carga del formulario
        private void historial_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        // Botón para volver al menú principal
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu abrir = new menu();
            abrir.Show();
        }

        // Botón para eliminar un registro seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Obtener el ID del pastel seleccionado
                int id_pastel = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id_pastel"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el registro de la base de datos
                    EliminarRegistro(id_pastel);

                    // Actualizar el DataGridView
                    MostrarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro para eliminar.");
            }
        }

        // Método para eliminar un registro de la base de datos
        private void EliminarRegistro(int id_pastel)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM pasteles WHERE id_pastel = @id_pastel";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_pastel", id_pastel);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método para mostrar los datos en el DataGridView
        private void MostrarDatos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id_pastel, tipo, sabor, relleno, leyenda, precio FROM pasteles;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    ActualizarDatos(dataTable);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento del DataGridView (puede no ser necesario dependiendo de tu implementación)
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
