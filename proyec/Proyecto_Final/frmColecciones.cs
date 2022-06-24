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
            cmbColec.DataSource = null;
            cmbColec.ValueMember = "id_coleccion";
            cmbColec.DisplayMember = "nombre";
            cmbColec.DataSource = coleccionesDAO.ObtColeccion();

        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            txtcolec.Clear();
            string name = cmbColec.Text;
            colecciones col = coleccionesDAO.filNombre(name);

            txtcolec.AppendText(col.id_coleccion + ": "+ col.nombre + " - ");
            txtcolec.AppendText(col.genero + Environment.NewLine);
        }
    }
}