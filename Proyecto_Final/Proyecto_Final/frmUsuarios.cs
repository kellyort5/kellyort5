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
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = UsuariosDAO.MostrarUsuarios();

            cmbOcupacion.DataSource = null;
            cmbOcupacion.ValueMember = "id_ocupacion";
            cmbOcupacion.DisplayMember = "ocupacion";
            cmbOcupacion.DataSource = OcupacionDAO.MostrarOcupaciones();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string institucion = txtinstitucion.Text;
            int idOcupacion;
            idOcupacion = Convert.ToInt32(cmbOcupacion.SelectedIndex);
            string correo = txtCorreo.Text;

            if (nombre.Length>0 && telefono.Length>0 && direccion.Length>0 && institucion.Length > 0 && correo.Length>0)
            {
                if (UsuariosDAO.InsertarUsuario(nombre,telefono,direccion,institucion,correo,idOcupacion))
                {
                    MessageBox.Show("Usuario agregado correctamente","POO",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtDireccion.Clear();
                    txtinstitucion.Clear();
                    txtCorreo.Clear();
                }
                else {
                    MessageBox.Show("Ocurrio un error, intente mas tarde","POO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Por favor llena todos los campos","POO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbOcupacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            txtNombre.Text = row.Cells[1].Value.ToString();
            txtTelefono.Text = row.Cells[2].Value.ToString();
            txtDireccion.Text = row.Cells[3].Value.ToString();
            txtinstitucion.Text = row.Cells[4].Value.ToString();
            txtCorreo.Text = row.Cells[5].Value.ToString();
            cmbOcupacion.Text = row.Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsuario.CurrentRow;
            int id_user = 0; 
            id_user = Convert.ToInt32(row.Cells["id"].Value);

            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Elimiar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UsuariosDAO.EliminarUser(id_user);
                MessageBox.Show("Usuario eliminado correctamente","Confirmacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                txtinstitucion.Clear();
                txtCorreo.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrio un error, intente mas tarde","POO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}