using System;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmColecciones : Form
    {
        public frmColecciones()
        {
            InitializeComponent();
        }

        private void frmColecciones_Load(object sender, EventArgs e)
        {
            //Cargar nombre de la coleccion
            cmbColec.DataSource = null;
            cmbColec.SelectionStart = 0;
            cmbColec.ValueMember = "id_coleccion";
            cmbColec.DisplayMember = "nombre";
            cmbColec.DataSource = ColeccionesDAO.ObtColeccion();
            
            //Cargar el Data
            dgvColecciones.DataSource = null;
            dgvColecciones.DataSource = ColeccionesDAO.ObtColeccion();
            
            // cargar el tipo de colecciones
            cmbTipoColec.DataSource = null;
            cmbTipoColec.ValueMember = "id_coleccion";
            cmbTipoColec.DisplayMember = "coleccion";
            cmbTipoColec.DataSource = ColeccionesDAO.ObtColeccion();
            
            //Cargar el cmb de Area
            cmbArea.DataSource = null;
            cmbArea.ValueMember = "id_area";
            cmbArea.DisplayMember = "nombre";
            cmbArea.DataSource = AreasADO.MostrarAreas();
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string name = cmbColec.Text;

            dgvColecciones.DataSource = null;
            dgvColecciones.DataSource = ColeccionesDAO.filNombre(name);
        }

        private void dgvColecciones_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            txtNombre.Text = row.Cells[1].Value.ToString();
            txtGenero.Text = row.Cells[2].Value.ToString();
            cmbTipoColec.Text = row.Cells[3].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int id_coleccion;
            id_coleccion = Convert.ToInt32(cmbTipoColec.SelectedIndex);
            string genero = txtGenero.Text;
            int id_area;
            id_area = Convert.ToInt32(cmbArea.SelectedIndex);

            if (nombre.Length>0 && genero.Length>0)
            {
                if (ColeccionesDAO.InsertarColecciones(nombre,id_coleccion, genero,id_area))
                {
                    MessageBox.Show("Colecion agregado correctamente","POO",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtGenero.Clear();
                }
                else {
                    MessageBox.Show("Ocurrio un error, intente mas tarde","POO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Por favor llena todos los campos","POO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
    }
// Ahora si 