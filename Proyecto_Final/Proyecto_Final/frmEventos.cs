using System;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void lblFin_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            cmbEvento.DataSource = null;
            cmbEvento.ValueMember = "id_evento";
            cmbEvento.DisplayMember = "titulo";
            cmbEvento.DataSource = EventosDAO.ObtEvento();

            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtEvento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string name = cmbEvento.Text;
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.filNombre(name);
        }

        private void dgvEventos_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            txtnombreEvento.Text = row.Cells[1].Value.ToString();
            txtfecha.Text = row.Cells[2].Value.ToString();
            txtfechafin.Text = row.Cells[3].Value.ToString();
            txtasistentes.Text = row.Cells[4].Value.ToString();
            txtarea.Text = row.Cells[5].Value.ToString();
        }
    }
}