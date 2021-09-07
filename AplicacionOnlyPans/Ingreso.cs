using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionOnlyPans
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string Nombre = txtName.Text;
            string password = txtPassword.Text;



            if (this.txtName.Text == "Sebastian" && this.txtPassword.Text == "Sebastianadmin")
            {
                Ingreso llamar = new Ingreso();
                llamar.Show();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, revise si estan bien escritos");
            }

            txtName.Clear();
            txtPassword.Clear();


        }




        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            rtxtContainer.Text = txtName.Text + "-" + txtPassword.Text;
            txtName.Clear();
            txtPassword.Clear();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtContainer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            if (this.txtName.Text == "User" && this.txtPassword.Text == "User42")
            {
                Form3 llamar = new Form3();
                llamar.Show();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, revise si estan bien escritos");
            }
            rtxtContainer.Text = txtName.Text + "-" + txtPassword.Text;
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}