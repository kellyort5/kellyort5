using System.ComponentModel;

namespace Proyecto_Final
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbrestaurar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbcerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.lblBinaes = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReserva = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEjemplares = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnColeccion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEventos = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ptbrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ptbcerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.ptbrestaurar);
            this.panel1.Controls.Add(this.ptbMaximizar);
            this.panel1.Controls.Add(this.ptbMinimizar);
            this.panel1.Controls.Add(this.ptbcerrar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ptbrestaurar
            // 
            resources.ApplyResources(this.ptbrestaurar, "ptbrestaurar");
            this.ptbrestaurar.Image = global::Proyecto_Final.Properties.Resources.expand_spread_screen_enlarge_fullscreen_icon_190626;
            this.ptbrestaurar.Name = "ptbrestaurar";
            this.ptbrestaurar.TabStop = false;
            this.ptbrestaurar.Click += new System.EventHandler(this.ptbrestaurar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Image = global::Proyecto_Final.Properties.Resources.fullscreen_icon_icons;
            resources.ApplyResources(this.ptbMaximizar, "ptbMaximizar");
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click_1);
            // 
            // ptbMinimizar
            // 
            resources.ApplyResources(this.ptbMinimizar, "ptbMinimizar");
            this.ptbMinimizar.Image = global::Proyecto_Final.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbcerrar
            // 
            resources.ApplyResources(this.ptbcerrar, "ptbcerrar");
            this.ptbcerrar.Image = global::Proyecto_Final.Properties.Resources.emblemunreadable_93487;
            this.ptbcerrar.Name = "ptbcerrar";
            this.ptbcerrar.TabStop = false;
            this.ptbcerrar.Click += new System.EventHandler(this.ptbcerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DimGray;
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.btnPrestamo);
            this.pnlMenu.Controls.Add(this.lblBinaes);
            this.pnlMenu.Controls.Add(this.panel7);
            this.pnlMenu.Controls.Add(this.btnReserva);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.btnEjemplares);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.btnColeccion);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.btnEventos);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.FlatAppearance.BorderSize = 0;
            this.btnPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnPrestamo, "btnPrestamo");
            this.btnPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // lblBinaes
            // 
            this.lblBinaes.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblBinaes, "lblBinaes");
            this.lblBinaes.ForeColor = System.Drawing.Color.White;
            this.lblBinaes.Name = "lblBinaes";
            this.lblBinaes.Click += new System.EventHandler(this.lblBinaes_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnReserva, "btnReserva");
            this.btnReserva.ForeColor = System.Drawing.Color.White;
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnUsuarios, "btnUsuarios");
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnEjemplares
            // 
            this.btnEjemplares.BackColor = System.Drawing.Color.Transparent;
            this.btnEjemplares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjemplares.FlatAppearance.BorderSize = 0;
            this.btnEjemplares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnEjemplares, "btnEjemplares");
            this.btnEjemplares.ForeColor = System.Drawing.Color.White;
            this.btnEjemplares.Name = "btnEjemplares";
            this.btnEjemplares.UseVisualStyleBackColor = false;
            this.btnEjemplares.Click += new System.EventHandler(this.btnEjemplares_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnColeccion
            // 
            this.btnColeccion.BackColor = System.Drawing.Color.Transparent;
            this.btnColeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColeccion.FlatAppearance.BorderSize = 0;
            this.btnColeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnColeccion, "btnColeccion");
            this.btnColeccion.ForeColor = System.Drawing.Color.White;
            this.btnColeccion.Name = "btnColeccion";
            this.btnColeccion.UseVisualStyleBackColor = false;
            this.btnColeccion.Click += new System.EventHandler(this.btnColeccion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnEventos, "btnEventos");
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.pnlContenedor, "pnlContenedor");
            this.pnlContenedor.Name = "pnlContenedor";
            // 
            // frmIndex
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIndex";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.ptbrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ptbcerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReserva;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblBinaes;

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPrestamo;

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUsuarios;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnColeccion;
        private System.Windows.Forms.Button btnEjemplares;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button btnEventos;

        private System.Windows.Forms.PictureBox ptbrestaurar;

        private System.Windows.Forms.PictureBox ptbMaximizar;

        private System.Windows.Forms.PictureBox ptbMinimizar;

        private System.Windows.Forms.PictureBox ptbcerrar;

        internal System.Windows.Forms.Panel pnlContenedor;

        private System.Windows.Forms.Panel pnlMenu;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}