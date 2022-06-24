namespace Proyecto_Final
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.btnEntrar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnEntrar
      // 
      this.btnEntrar.BackColor = System.Drawing.SystemColors.Highlight;
      this.btnEntrar.FlatAppearance.BorderSize = 0;
      this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEntrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.btnEntrar.ForeColor = System.Drawing.Color.White;
      this.btnEntrar.Location = new System.Drawing.Point(163, 344);
      this.btnEntrar.Name = "btnEntrar";
      this.btnEntrar.Size = new System.Drawing.Size(177, 34);
      this.btnEntrar.TabIndex = 0;
      this.btnEntrar.Text = "Entrar";
      this.btnEntrar.UseVisualStyleBackColor = false;
      this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.BackgroundImage = global::Proyecto_Final.Properties.Resources.Binaes_Logo;
      this.ClientSize = new System.Drawing.Size(500, 433);
      this.Controls.Add(this.btnEntrar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnEntrar;

    private System.Windows.Forms.Button button1;

    #endregion
  }
}

