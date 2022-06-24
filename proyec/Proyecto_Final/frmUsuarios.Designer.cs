using System.ComponentModel;

namespace Proyecto_Final
{
    partial class frmUsuarios
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnusuario = new System.Windows.Forms.Button();
            this.grbacciones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.grpdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.grbacciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(351, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 57);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Usuarios";
            // 
            // grpdatos
            // 
            this.grpdatos.Controls.Add(this.textBox7);
            this.grpdatos.Controls.Add(this.textBox5);
            this.grpdatos.Controls.Add(this.label3);
            this.grpdatos.Controls.Add(this.comboBox1);
            this.grpdatos.Controls.Add(this.label1);
            this.grpdatos.Controls.Add(this.lblObjetivo);
            this.grpdatos.Controls.Add(this.textBox4);
            this.grpdatos.Controls.Add(this.lblFin);
            this.grpdatos.Controls.Add(this.textBox3);
            this.grpdatos.Controls.Add(this.lblInicio);
            this.grpdatos.Controls.Add(this.textBox2);
            this.grpdatos.Controls.Add(this.lblcantidad);
            this.grpdatos.Controls.Add(this.textBox1);
            this.grpdatos.Controls.Add(this.lblnombre);
            this.grpdatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpdatos.ForeColor = System.Drawing.Color.White;
            this.grpdatos.Location = new System.Drawing.Point(12, 69);
            this.grpdatos.Name = "grpdatos";
            this.grpdatos.Size = new System.Drawing.Size(649, 194);
            this.grpdatos.TabIndex = 10;
            this.grpdatos.TabStop = false;
            this.grpdatos.Text = "Datos del usuario";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(436, 55);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 113);
            this.textBox7.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(436, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(192, 23);
            this.textBox5.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(383, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Foto: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ocupacion: ";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblObjetivo.ForeColor = System.Drawing.Color.White;
            this.lblObjetivo.Location = new System.Drawing.Point(368, 25);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(129, 23);
            this.lblObjetivo.TabIndex = 8;
            this.lblObjetivo.Text = "Correo: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 23);
            this.textBox4.TabIndex = 7;
            // 
            // lblFin
            // 
            this.lblFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFin.ForeColor = System.Drawing.Color.White;
            this.lblFin.Location = new System.Drawing.Point(20, 113);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(99, 23);
            this.lblFin.TabIndex = 6;
            this.lblFin.Text = "Institucion: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 23);
            this.textBox3.TabIndex = 5;
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(29, 83);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(90, 23);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Direccion: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 23);
            this.textBox2.TabIndex = 3;
            // 
            // lblcantidad
            // 
            this.lblcantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(35, 55);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(84, 23);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "Telefono: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(44, 25);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(75, 23);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.Goldenrod;
            this.btnusuario.FlatAppearance.BorderSize = 0;
            this.btnusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnusuario.ForeColor = System.Drawing.Color.White;
            this.btnusuario.Location = new System.Drawing.Point(678, 13);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(201, 29);
            this.btnusuario.TabIndex = 3;
            this.btnusuario.Text = "Buscar";
            this.btnusuario.UseVisualStyleBackColor = false;
            // 
            // grbacciones
            // 
            this.grbacciones.Controls.Add(this.btnAgregar);
            this.grbacciones.Controls.Add(this.button3);
            this.grbacciones.Controls.Add(this.button2);
            this.grbacciones.Location = new System.Drawing.Point(667, 69);
            this.grbacciones.Name = "grbacciones";
            this.grbacciones.Size = new System.Drawing.Size(251, 194);
            this.grbacciones.TabIndex = 11;
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre usuario: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.cmbUsuario);
            this.groupBox1.Controls.Add(this.btnusuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 224);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsuario.Location = new System.Drawing.Point(20, 53);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(861, 165);
            this.txtUsuario.TabIndex = 14;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(157, 18);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(414, 21);
            this.cmbUsuario.TabIndex = 13;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(930, 505);
            this.Controls.Add(this.grbacciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpdatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.grpdatos.ResumeLayout(false);
            this.grpdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.grbacciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;

        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.GroupBox grbacciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpdatos;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.Label lblInicio;

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcantidad;

        private System.Windows.Forms.Label lblTitulo;

        #endregion
    }
}