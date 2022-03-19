using Datos.Acceso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }
        UsuarioR usuarioR = new UsuarioR();
        private void Registro_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            UsuariosDataGridView.DataSource = usuarioR.ListarUsuarios();

        }



    }
}
