using System;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "id_usuario";
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.DataSource = usuarioDAO.Obtusuairio();
        }
    }
}