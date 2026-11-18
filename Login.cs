using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Water_business
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Inicio mostrar = new Inicio();
            mostrar.Show();
            this.Hide();
            mostrar.FormClosing += Closing;

        }

        private void Closing(Object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtcontraseña.Text = "";
            this.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
