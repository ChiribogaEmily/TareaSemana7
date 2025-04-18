namespace Usuarios
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            panel1 = new Panel();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAceptar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 361);
            panel1.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(50, 153);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(204, 25);
            txtContraseña.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(50, 88);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(204, 25);
            txtUsuario.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 134);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(94, 282);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(94, 223);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 34);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 361);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  Inicio de Sesión";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}
