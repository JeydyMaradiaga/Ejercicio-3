using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Acceso;
using Datos.Entidades;


namespace Ejercicio_3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            UsuarioR usuarioR = new UsuarioR();
            Usuario usuario = new Usuario();

            usuario = usuarioR.Login(txt_Usuario.Text, txt_Contraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }


            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.Show();

        }
    }
}

