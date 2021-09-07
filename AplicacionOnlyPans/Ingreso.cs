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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "Admin" && this.txtContraseña.Text == "admin")
            {
                Form2 llamar = new Form2();
                llamar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña Incorrecta");
            }
        }
    }
}
