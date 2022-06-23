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
            cmbColec.DisplayMember = "genero";
            cmbColec.DataSource = coleccionDAO.ObtColeccion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtColec.Clear();
            string name = cmbColec.Text;
            colecciones col = coleccionDAO.filname(name);

            txtColec.AppendText(col.id_coleccion + ": "+ col.nombre + " - ");
            txtColec.AppendText(col.genero + Environment.NewLine);
        }
    }
}