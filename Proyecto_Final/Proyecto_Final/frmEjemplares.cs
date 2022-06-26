using System;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmEjemplares : Form
    {
        public frmEjemplares()
        {
            InitializeComponent();
        }

        private void frmEjemplares_Load(object sender, EventArgs e)
        {

            dgvEjemplares.DataSource = null;
            dgvEjemplares.DataSource = EjemplarDAO.ObtEjemplar();
            
            cmbEjemplar.DataSource = null;
            cmbEjemplar.ValueMember = "id_ejemplar";
            cmbEjemplar.DisplayMember = "nombre";
            cmbEjemplar.DataSource = EjemplarDAO.ObtEjemplar();
            
            cmbColeccion.DataSource = null;
            cmbColeccion.ValueMember = "id_coleccion";
            cmbColeccion.DisplayMember = "coleccion";
            cmbColeccion.DataSource = EjemplarDAO.ObtEjemplar();
        }
        private void dgvEjemplares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                //Obtienes la fila actual
                var row = (sender as DataGridView).CurrentRow;

                txtNejemplar.Text = row.Cells[1].Value.ToString();
                txteditorial.Text = row.Cells[2].Value.ToString();
                txtfecha.Text = row.Cells[3].Value.ToString();
                txtidioma.Text = row.Cells[4].Value.ToString();
                cmbColeccion.Text = row.Cells[5].Value.ToString();
                txtformato.Text = row.Cells[6].Value.ToString();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string name = cmbEjemplar.Text;
            dgvEjemplares.DataSource = null;
            dgvEjemplares.DataSource = EjemplarDAO.filNombre(name);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNejemplar.Text;
            string editorial_empresa = txteditorial.Text;
            string fecha_publicacion = txtfecha.Text;
            string idioma = txtidioma.Text;
            int idColeccion = 0;
            idColeccion = Convert.ToInt32(cmbColeccion.SelectedIndex);
            string formato = txtformato.Text;

            if (nombre.Length > 0 && editorial_empresa.Length > 0 && fecha_publicacion.Length > 0 &&
                idioma.Length > 0 && formato.Length > 0)
            {
                if (EjemplarDAO.InsertarEjemplar(nombre, editorial_empresa, fecha_publicacion, idioma, idColeccion,
                        formato))
                {
                    MessageBox.Show("Usuario agregado correctamente", "POO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtNejemplar.Clear();
                    txteditorial.Clear();
                    txtfecha.Clear();
                    txtidioma.Clear();
                    txtformato.Clear();

                }
                else
                {
                    MessageBox.Show("Ocurrio un error, intente mas tarde", "POO", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos", "POO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        
    }
}
