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
            cmbEjemplar.DataSource = null;
            cmbEjemplar.ValueMember = "id_ejemplar";
            cmbEjemplar.DisplayMember = "nombre";
            cmbEjemplar.DataSource = ejemplarDAO.Obtejemplar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            txtEjemplar.Clear();
            string name = txtEjemplar.Text;
            ejemplar col = ejemplarDAO.filNeje(name);

            txtEjemplar.AppendText(col.id_ejemplar + ": "+ col.nombre + " - "+col.editorial_empresa);
            txtEjemplar.AppendText(col.id_coleccion+" - "+col.id_formato + Environment.NewLine);
        }
    }
}
//col.fecha_publicacion