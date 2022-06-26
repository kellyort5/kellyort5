using System.ComponentModel;

namespace Proyecto_Final
{
    partial class frmColecciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvColecciones = new System.Windows.Forms.DataGridView();
            this.cmbColec = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbacciones = new System.Windows.Forms.GroupBox();
            this.grpdatos = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoColec = new System.Windows.Forms.ComboBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvColecciones)).BeginInit();
            this.grbacciones.SuspendLayout();
            this.grpdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(413, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(428, 70);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Colecciones";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(31, 48);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(268, 47);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvColecciones);
            this.groupBox1.Controls.Add(this.cmbColec);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 331);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1208, 276);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dgvColecciones
            // 
            this.dgvColecciones.AllowUserToAddRows = false;
            this.dgvColecciones.AllowUserToDeleteRows = false;
            this.dgvColecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColecciones.Location = new System.Drawing.Point(180, 59);
            this.dgvColecciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvColecciones.Name = "dgvColecciones";
            this.dgvColecciones.ReadOnly = true;
            this.dgvColecciones.Size = new System.Drawing.Size(807, 209);
            this.dgvColecciones.TabIndex = 14;
            this.dgvColecciones.SelectionChanged += new System.EventHandler(this.dgvColecciones_SelectionChanged);
            // 
            // cmbColec
            // 
            this.cmbColec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColec.FormattingEnabled = true;
            this.cmbColec.Location = new System.Drawing.Point(276, 23);
            this.cmbColec.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColec.Name = "cmbColec";
            this.cmbColec.Size = new System.Drawing.Size(588, 24);
            this.cmbColec.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(904, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(268, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre de la coleccion: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(31, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(31, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // grbacciones
            // 
            this.grbacciones.Controls.Add(this.btnAgregar);
            this.grbacciones.Controls.Add(this.button3);
            this.grbacciones.Controls.Add(this.button2);
            this.grbacciones.Location = new System.Drawing.Point(889, 80);
            this.grbacciones.Margin = new System.Windows.Forms.Padding(4);
            this.grbacciones.Name = "grbacciones";
            this.grbacciones.Padding = new System.Windows.Forms.Padding(4);
            this.grbacciones.Size = new System.Drawing.Size(335, 239);
            this.grbacciones.TabIndex = 8;
            this.grbacciones.TabStop = false;
            // 
            // grpdatos
            // 
            this.grpdatos.Controls.Add(this.cmbArea);
            this.grpdatos.Controls.Add(this.label1);
            this.grpdatos.Controls.Add(this.cmbTipoColec);
            this.grpdatos.Controls.Add(this.txtGenero);
            this.grpdatos.Controls.Add(this.lblInicio);
            this.grpdatos.Controls.Add(this.lblcantidad);
            this.grpdatos.Controls.Add(this.txtNombre);
            this.grpdatos.Controls.Add(this.lblnombre);
            this.grpdatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpdatos.ForeColor = System.Drawing.Color.White;
            this.grpdatos.Location = new System.Drawing.Point(16, 80);
            this.grpdatos.Margin = new System.Windows.Forms.Padding(4);
            this.grpdatos.Name = "grpdatos";
            this.grpdatos.Padding = new System.Windows.Forms.Padding(4);
            this.grpdatos.Size = new System.Drawing.Size(865, 239);
            this.grpdatos.TabIndex = 7;
            this.grpdatos.TabStop = false;
            this.grpdatos.Text = "Datos coleccion";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(426, 179);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(220, 26);
            this.cmbArea.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Area";
            // 
            // cmbTipoColec
            // 
            this.cmbTipoColec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoColec.FormattingEnabled = true;
            this.cmbTipoColec.Location = new System.Drawing.Point(427, 102);
            this.cmbTipoColec.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoColec.Name = "cmbTipoColec";
            this.cmbTipoColec.Size = new System.Drawing.Size(220, 26);
            this.cmbTipoColec.TabIndex = 11;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(427, 138);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(220, 26);
            this.txtGenero.TabIndex = 5;
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(217, 139);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(201, 28);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Genero";
            // 
            // lblcantidad
            // 
            this.lblcantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(217, 103);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(201, 28);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "Tipo de coleccion: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(323, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(217, 68);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(97, 28);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre: ";
            // 
            // frmColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1240, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbacciones);
            this.Controls.Add(this.grpdatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmColecciones";
            this.Text = "frmColecciones";
            this.Load += new System.EventHandler(this.frmColecciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvColecciones)).EndInit();
            this.grbacciones.ResumeLayout(false);
            this.grpdatos.ResumeLayout(false);
            this.grpdatos.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbArea;

        private System.Windows.Forms.DataGridView dgvColecciones;

        private System.Windows.Forms.ComboBox cmbColec;

        private System.Windows.Forms.ComboBox cmbTipoColec;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbacciones;
        private System.Windows.Forms.GroupBox grpdatos;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblnombre;

        private System.Windows.Forms.Label lblTitulo;

        #endregion
    }
}