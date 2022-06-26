using System.ComponentModel;

namespace Proyecto_Final
{
    partial class frmEjemplares
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbacciones = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpdatos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtformato = new System.Windows.Forms.TextBox();
            this.cmbColeccion = new System.Windows.Forms.ComboBox();
            this.grpPcla = new System.Windows.Forms.GroupBox();
            this.btnAGclave = new System.Windows.Forms.Button();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidioma = new System.Windows.Forms.TextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtNejemplar = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEjemplares = new System.Windows.Forms.DataGridView();
            this.cmbEjemplar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbacciones.SuspendLayout();
            this.grpdatos.SuspendLayout();
            this.grpPcla.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(329, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 57);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Ejemplares";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(23, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(201, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(23, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // grbacciones
            // 
            this.grbacciones.Controls.Add(this.btnAgregar);
            this.grbacciones.Controls.Add(this.button3);
            this.grbacciones.Controls.Add(this.button2);
            this.grbacciones.Location = new System.Drawing.Point(667, 69);
            this.grbacciones.Name = "grbacciones";
            this.grbacciones.Size = new System.Drawing.Size(251, 194);
            this.grbacciones.TabIndex = 8;
            this.grbacciones.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(23, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(678, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(201, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpdatos
            // 
            this.grpdatos.Controls.Add(this.label3);
            this.grpdatos.Controls.Add(this.txtformato);
            this.grpdatos.Controls.Add(this.cmbColeccion);
            this.grpdatos.Controls.Add(this.grpPcla);
            this.grpdatos.Controls.Add(this.label1);
            this.grpdatos.Controls.Add(this.txtidioma);
            this.grpdatos.Controls.Add(this.lblFin);
            this.grpdatos.Controls.Add(this.txtfecha);
            this.grpdatos.Controls.Add(this.lblInicio);
            this.grpdatos.Controls.Add(this.txteditorial);
            this.grpdatos.Controls.Add(this.lblcantidad);
            this.grpdatos.Controls.Add(this.txtNejemplar);
            this.grpdatos.Controls.Add(this.lblnombre);
            this.grpdatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpdatos.ForeColor = System.Drawing.Color.White;
            this.grpdatos.Location = new System.Drawing.Point(12, 69);
            this.grpdatos.Name = "grpdatos";
            this.grpdatos.Size = new System.Drawing.Size(649, 255);
            this.grpdatos.TabIndex = 7;
            this.grpdatos.TabStop = false;
            this.grpdatos.Text = "Datos del evento";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Formato: ";
            // 
            // txtformato
            // 
            this.txtformato.Location = new System.Drawing.Point(176, 176);
            this.txtformato.Name = "txtformato";
            this.txtformato.Size = new System.Drawing.Size(166, 23);
            this.txtformato.TabIndex = 17;
            // 
            // cmbColeccion
            // 
            this.cmbColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColeccion.FormattingEnabled = true;
            this.cmbColeccion.Location = new System.Drawing.Point(176, 147);
            this.cmbColeccion.Name = "cmbColeccion";
            this.cmbColeccion.Size = new System.Drawing.Size(167, 23);
            this.cmbColeccion.TabIndex = 16;
            // 
            // grpPcla
            // 
            this.grpPcla.Controls.Add(this.btnAGclave);
            this.grpPcla.Controls.Add(this.txtPalabras);
            this.grpPcla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpPcla.Location = new System.Drawing.Point(358, 22);
            this.grpPcla.Name = "grpPcla";
            this.grpPcla.Size = new System.Drawing.Size(285, 146);
            this.grpPcla.TabIndex = 12;
            this.grpPcla.TabStop = false;
            this.grpPcla.Text = "Palabras Clave";
            // 
            // btnAGclave
            // 
            this.btnAGclave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAGclave.FlatAppearance.BorderSize = 0;
            this.btnAGclave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGclave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAGclave.ForeColor = System.Drawing.Color.White;
            this.btnAGclave.Location = new System.Drawing.Point(38, 91);
            this.btnAGclave.Name = "btnAGclave";
            this.btnAGclave.Size = new System.Drawing.Size(201, 38);
            this.btnAGclave.TabIndex = 4;
            this.btnAGclave.Text = "Agregar";
            this.btnAGclave.UseVisualStyleBackColor = false;
            // 
            // txtPalabras
            // 
            this.txtPalabras.Location = new System.Drawing.Point(6, 16);
            this.txtPalabras.Multiline = true;
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPalabras.Size = new System.Drawing.Size(273, 67);
            this.txtPalabras.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Coleccion: ";
            // 
            // txtidioma
            // 
            this.txtidioma.Location = new System.Drawing.Point(176, 113);
            this.txtidioma.Name = "txtidioma";
            this.txtidioma.Size = new System.Drawing.Size(166, 23);
            this.txtidioma.TabIndex = 7;
            // 
            // lblFin
            // 
            this.lblFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFin.ForeColor = System.Drawing.Color.White;
            this.lblFin.Location = new System.Drawing.Point(103, 113);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(62, 23);
            this.lblFin.TabIndex = 6;
            this.lblFin.Text = "Idioma: ";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(177, 82);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(166, 23);
            this.txtfecha.TabIndex = 5;
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(20, 83);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(151, 23);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Fecha publicacion: ";
            // 
            // txteditorial
            // 
            this.txteditorial.Location = new System.Drawing.Point(177, 54);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(166, 23);
            this.txteditorial.TabIndex = 3;
            // 
            // lblcantidad
            // 
            this.lblcantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(91, 55);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(79, 23);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "Editorial: ";
            // 
            // txtNejemplar
            // 
            this.txtNejemplar.Location = new System.Drawing.Point(176, 24);
            this.txtNejemplar.Name = "txtNejemplar";
            this.txtNejemplar.Size = new System.Drawing.Size(167, 23);
            this.txtNejemplar.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(29, 25);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(141, 23);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre ejemplar: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEjemplares);
            this.groupBox1.Controls.Add(this.cmbEjemplar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dgvEjemplares
            // 
            this.dgvEjemplares.AllowUserToAddRows = false;
            this.dgvEjemplares.AllowUserToDeleteRows = false;
            this.dgvEjemplares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEjemplares.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplares.Location = new System.Drawing.Point(20, 48);
            this.dgvEjemplares.Name = "dgvEjemplares";
            this.dgvEjemplares.ReadOnly = true;
            this.dgvEjemplares.Size = new System.Drawing.Size(859, 109);
            this.dgvEjemplares.TabIndex = 15;
            this.dgvEjemplares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjemplares_CellContentClick);
            // 
            // cmbEjemplar
            // 
            this.cmbEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjemplar.FormattingEnabled = true;
            this.cmbEjemplar.Location = new System.Drawing.Point(191, 19);
            this.cmbEjemplar.Name = "cmbEjemplar";
            this.cmbEjemplar.Size = new System.Drawing.Size(475, 21);
            this.cmbEjemplar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del Ejemplar: ";
            // 
            // frmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(930, 505);
            this.Controls.Add(this.grbacciones);
            this.Controls.Add(this.grpdatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjemplares";
            this.Text = "frmEjemplares";
            this.Load += new System.EventHandler(this.frmEjemplares_Load);
            this.grbacciones.ResumeLayout(false);
            this.grpdatos.ResumeLayout(false);
            this.grpdatos.PerformLayout();
            this.grpPcla.ResumeLayout(false);
            this.grpPcla.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEjemplares)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAGclave;

        private System.Windows.Forms.TextBox txtformato;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox cmbColeccion;

        private System.Windows.Forms.DataGridView dgvEjemplares;

        private System.Windows.Forms.ComboBox cmbEjemplar;

        private System.Windows.Forms.GroupBox grpPcla;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbacciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.TextBox txtidioma;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtNejemplar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lblTitulo;

        #endregion
    }
}