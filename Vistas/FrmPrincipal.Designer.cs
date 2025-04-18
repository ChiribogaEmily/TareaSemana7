namespace Usuarios.Views
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnUsuarios = new Button();
            btnRoles = new Button();
            panel1 = new Panel();
            btnServicios = new Button();
            contenedor = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Left;
            btnUsuarios.FlatAppearance.BorderSize = 2;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.FromArgb(64, 0, 0);
            btnUsuarios.Location = new Point(273, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(317, 103);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsers_Click;
            // 
            // btnRoles
            // 
            btnRoles.Dock = DockStyle.Left;
            btnRoles.FlatAppearance.BorderSize = 2;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoles.ForeColor = Color.FromArgb(64, 0, 0);
            btnRoles.Location = new Point(0, 0);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(273, 103);
            btnRoles.TabIndex = 1;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnServicios);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnRoles);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 105);
            panel1.TabIndex = 2;
            // 
            // btnServicios
            // 
            btnServicios.Dock = DockStyle.Left;
            btnServicios.FlatAppearance.BorderSize = 2;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServicios.ForeColor = Color.FromArgb(64, 0, 0);
            btnServicios.Location = new Point(590, 0);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(304, 103);
            btnServicios.TabIndex = 4;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // contenedor
            // 
            contenedor.Controls.Add(label1);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 105);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(895, 488);
            contenedor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(343, 171);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al sistema";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 593);
            Controls.Add(contenedor);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Button btnRoles;
        private Panel panel1;
        private Button btnServicios;
        private Panel contenedor;
        private Label label1;
    }
}