using System.ComponentModel;

namespace Proyecto_Final
{
    partial class frmEventos
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
            this.grpdatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtfechafin = new System.Windows.Forms.TextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtasistentes = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtnombreEvento = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.grbacciones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.grpdatos.SuspendLayout();
            this.grbacciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(380, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 57);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Eventos";
            // 
            // grpdatos
            // 
            this.grpdatos.Controls.Add(this.txtarea);
            this.grpdatos.Controls.Add(this.label3);
            this.grpdatos.Controls.Add(this.label1);
            this.grpdatos.Controls.Add(this.textBox5);
            this.grpdatos.Controls.Add(this.lblObjetivo);
            this.grpdatos.Controls.Add(this.txtfechafin);
            this.grpdatos.Controls.Add(this.lblFin);
            this.grpdatos.Controls.Add(this.txtfecha);
            this.grpdatos.Controls.Add(this.lblInicio);
            this.grpdatos.Controls.Add(this.txtasistentes);
            this.grpdatos.Controls.Add(this.lblcantidad);
            this.grpdatos.Controls.Add(this.txtnombreEvento);
            this.grpdatos.Controls.Add(this.lblnombre);
            this.grpdatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpdatos.ForeColor = System.Drawing.Color.White;
            this.grpdatos.Location = new System.Drawing.Point(12, 69);
            this.grpdatos.Name = "grpdatos";
            this.grpdatos.Size = new System.Drawing.Size(649, 194);
            this.grpdatos.TabIndex = 3;
            this.grpdatos.TabStop = false;
            this.grpdatos.Text = "Datos del evento";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imagen: ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(368, 52);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(263, 55);
            this.textBox5.TabIndex = 9;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblObjetivo.ForeColor = System.Drawing.Color.White;
            this.lblObjetivo.Location = new System.Drawing.Point(368, 25);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(129, 23);
            this.lblObjetivo.TabIndex = 8;
            this.lblObjetivo.Text = "Objetivos: ";
            // 
            // txtfechafin
            // 
            this.txtfechafin.Location = new System.Drawing.Point(177, 112);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(166, 23);
            this.txtfechafin.TabIndex = 7;
            // 
            // lblFin
            // 
            this.lblFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFin.ForeColor = System.Drawing.Color.White;
            this.lblFin.Location = new System.Drawing.Point(42, 113);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(129, 23);
            this.lblFin.TabIndex = 6;
            this.lblFin.Text = "Hora y fecha fin: ";
            this.lblFin.Click += new System.EventHandler(this.lblFin_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(177, 83);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(166, 23);
            this.txtfecha.TabIndex = 5;
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(20, 84);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(151, 23);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Hora y fecha inicio: ";
            // 
            // txtasistentes
            // 
            this.txtasistentes.Location = new System.Drawing.Point(177, 54);
            this.txtasistentes.Name = "txtasistentes";
            this.txtasistentes.Size = new System.Drawing.Size(95, 23);
            this.txtasistentes.TabIndex = 3;
            // 
            // lblcantidad
            // 
            this.lblcantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(67, 55);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(104, 23);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "# Asistentes:  ";
            // 
            // txtnombreEvento
            // 
            this.txtnombreEvento.Location = new System.Drawing.Point(177, 25);
            this.txtnombreEvento.Name = "txtnombreEvento";
            this.txtnombreEvento.Size = new System.Drawing.Size(166, 23);
            this.txtnombreEvento.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(20, 26);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(151, 23);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre del evento: ";
            // 
            // grbacciones
            // 
            this.grbacciones.Controls.Add(this.btnAgregar);
            this.grbacciones.Controls.Add(this.button3);
            this.grbacciones.Controls.Add(this.button2);
            this.grbacciones.Location = new System.Drawing.Point(667, 69);
            this.grbacciones.Name = "grbacciones";
            this.grbacciones.Size = new System.Drawing.Size(251, 194);
            this.grbacciones.TabIndex = 4;
            this.grbacciones.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEventos);
            this.groupBox1.Controls.Add(this.cmbEvento);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(20, 48);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(859, 170);
            this.dgvEventos.TabIndex = 16;
            this.dgvEventos.SelectionChanged += new System.EventHandler(this.dgvEventos_SelectionChanged);
            // 
            // cmbEvento
            // 
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(174, 19);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(475, 21);
            this.cmbEvento.TabIndex = 14;
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del evento: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(368, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Area: ";
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(465, 113);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(166, 23);
            this.txtarea.TabIndex = 12;
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(930, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbacciones);
            this.Controls.Add(this.grpdatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventos";
            this.Text = "frmEventos";
            this.Load += new System.EventHandler(this.frmEventos_Load);
            this.grpdatos.ResumeLayout(false);
            this.grpdatos.PerformLayout();
            this.grbacciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtarea;

        private System.Windows.Forms.DataGridView dgvEventos;

        private System.Windows.Forms.ComboBox cmbEvento;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtfechafin;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtasistentes;
        private System.Windows.Forms.TextBox txtfecha;

        private System.Windows.Forms.TextBox txtnombreEvento;

        private System.Windows.Forms.GroupBox grpdatos;
        private System.Windows.Forms.Label lblInicio;

        private System.Windows.Forms.GroupBox grbacciones;

        private System.Windows.Forms.Label lblTitulo;

        #endregion
    }
}