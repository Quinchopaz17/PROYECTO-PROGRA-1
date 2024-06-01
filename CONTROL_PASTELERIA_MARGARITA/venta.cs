using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CONTROL_PASTELERIA_MARGARITA
{
    public partial class venta : Form
    {
        public class Pastel
        {
            public string tipo { get; set; }
            public string sabor { get; set; }
            public string relleno { get; set; }
            public string leyenda { get; set; }
            public string precio { get; set; }
         
        }

        string connectionString = "Server=localhost;Database=pasteleria;User Id=root;Password=";

        public venta()
        {
            InitializeComponent();
            // Asocia el evento KeyPress al TextBox
            txtprecio.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            // Asocia el evento TextChanged al TextBox
            txtprecio.TextChanged += new EventHandler(textBox1_TextChanged_1);
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Verifica si el texto tiene más de 6 caracteres y recorta si es necesario
            if (txtprecio.Text.Length > 6)
            {
                txtprecio.Text = txtprecio.Text.Substring(0, 6);
                txtprecio.SelectionStart = txtprecio.Text.Length; // Mueve el cursor al final del texto
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un dígito o la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un dígito ni backspace, cancela el evento
                e.Handled = true;
            }

            // Verifica si el texto actual más la nueva entrada excede los 6 caracteres
            if (txtprecio.Text.Length >= 6 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Opcional: También puedes permitir la tecla de punto si necesitas números decimales
            // if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') == -1)
            // {
            //     e.Handled = false;
            // }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxtipopastel.Text;
            string sabor = comboBoxsabor.Text;
            string relleno = comboBoxrelleno.Text;
            string leyenda = txtleyenda.Text;
            string precio = txtprecio.Text;
         

            Pastel pastel = new Pastel
            {
                tipo = tipo,
                sabor = sabor,
                relleno = relleno,
                leyenda = leyenda,
                precio = precio,
         
            };

            GuardarPastel(pastel);
        }

        private void GuardarPastel(Pastel pastel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO pasteles (tipo, sabor, relleno, leyenda, precio) VALUES (@tipo, @sabor, @relleno, @leyenda, @precio)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@tipo", pastel.tipo);
                cmd.Parameters.AddWithValue("@sabor", pastel.sabor);
                cmd.Parameters.AddWithValue("@relleno", pastel.relleno);
                cmd.Parameters.AddWithValue("@leyenda", pastel.leyenda);
                cmd.Parameters.AddWithValue("@precio", pastel.precio);
                

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente.");
                    LimpiarCampos(); // Llama a la función para limpiar los campos de entrada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
            }
        }
    


private void LimpiarCampos()
        {
            comboBoxtipopastel.SelectedIndex = -1;
            comboBoxsabor.SelectedIndex = -1;
            comboBoxrelleno.SelectedIndex = -1;
            txtleyenda.Clear();
            txtprecio.Clear();
        }

        private void venta_Load(object sender, EventArgs e)
        {

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu abrir = new menu();
            abrir.Show();
        }

        private void pedidospendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
