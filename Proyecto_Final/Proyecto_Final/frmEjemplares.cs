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
            cmbEvent.DataSource = null;
            cmbEvent.ValueMember = "id_ejemplar";
            cmbEvent.DisplayMember = "nombre";
            cmbEvent.DataSource = EjemplaresDAO.ObtEjemplaresList();
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            
            txtEjem.Clear();
            string name = txtEjem.Text;
            Ejemplares ej = EjemplaresDAO.filname(name);
            txtEjem.AppendText(ej.id_ejemplar + ": "+ ej.nombre + " - ");
            txtEjem.AppendText(ej.editorial_empresa + " - " + ej.idioma);
            txtEjem.AppendText(ej.id_coleccion+ " - "+ej.id_formato + Environment.NewLine);
        }
    }
}