using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Academia.WindowsForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            // Configuración general
            this.AcceptButton = btnIngresar;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            txtPass.UseSystemPasswordChar = true;
        }

        // Botón Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtPass.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Usuario y/o contraseña incorrectos",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Link "Olvidé mi contraseña"
        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Es Ud. un usuario muy descuidado, haga memoria",
                "Olvidé mi contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}

