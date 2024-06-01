using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_PASTELERIA_MARGARITA
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //pide validacion de datos en el cuadrode texto
            if (txtusuario.Text == "Pasteles")
            {
                if (txtcontraseña.Text == "Margarita")
                {
                    this.Hide();
                    menu abrir = new menu();
                    abrir.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                  

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
          
            
           
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
