using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Final
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
            lblBinaes_Click(null,EventArgs.Empty);
        }

        private void ptbcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMaximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ptbMaximizar.Visible = false;
            ptbrestaurar.Visible = true;
        }

        private void ptbrestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ptbrestaurar.Visible = false;
            ptbMaximizar.Visible = true;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        private void AbrirForm(object formDep)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);
            Form fh = formDep as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(fh);
                pnlContenedor.Tag = fh;
                fh.Show();
        }
        private void btnEventos_Click(object sender, EventArgs e)
        {
            AbrirForm( new frmEventos());
        }

        private void btnColeccion_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmColecciones());
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEjemplares());
        }

        private void lblBinaes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuarios());
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPrestamo());
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReserva());
        }
    }
}