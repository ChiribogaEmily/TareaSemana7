namespace Usuarios.Views.Inicio
{
    partial class UC_Home
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTotalDepartments = new Label();
            lblTotalBussines = new Label();
            lblTotalRoles = new Label();
            lblTotalUsers = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalDepartments);
            panel1.Controls.Add(lblTotalBussines);
            panel1.Controls.Add(lblTotalRoles);
            panel1.Controls.Add(lblTotalUsers);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 526);
            panel1.TabIndex = 0;
            // 
            // lblTotalDepartments
            // 
            lblTotalDepartments.AutoSize = true;
            lblTotalDepartments.ForeColor = Color.Navy;
            lblTotalDepartments.Location = new Point(484, 385);
            lblTotalDepartments.Name = "lblTotalDepartments";
            lblTotalDepartments.Size = new Size(42, 32);
            lblTotalDepartments.TabIndex = 7;
            lblTotalDepartments.Text = "10";
            // 
            // lblTotalBussines
            // 
            lblTotalBussines.AutoSize = true;
            lblTotalBussines.ForeColor = Color.Navy;
            lblTotalBussines.Location = new Point(180, 385);
            lblTotalBussines.Name = "lblTotalBussines";
            lblTotalBussines.Size = new Size(28, 32);
            lblTotalBussines.TabIndex = 6;
            lblTotalBussines.Text = "2";
            // 
            // lblTotalRoles
            // 
            lblTotalRoles.AutoSize = true;
            lblTotalRoles.ForeColor = Color.Navy;
            lblTotalRoles.Location = new Point(488, 154);
            lblTotalRoles.Name = "lblTotalRoles";
            lblTotalRoles.Size = new Size(28, 32);
            lblTotalRoles.TabIndex = 5;
            lblTotalRoles.Text = "0";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.ForeColor = Color.Navy;
            lblTotalUsers.Location = new Point(180, 154);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(28, 32);
            lblTotalUsers.TabIndex = 4;
            lblTotalUsers.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 318);
            label4.Name = "label4";
            label4.Size = new Size(278, 32);
            label4.TabIndex = 3;
            label4.Text = "Departamentos Totales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 318);
            label3.Name = "label3";
            label3.Size = new Size(209, 32);
            label3.TabIndex = 2;
            label3.Text = "Empresas Totales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 102);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 1;
            label2.Text = "Roles Totales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 102);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuarios Totales";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            MaximumSize = new Size(697, 526);
            MinimumSize = new Size(697, 526);
            Name = "UC_Home";
            Size = new Size(697, 526);
            Load += UC_Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTotalDepartments;
        private Label lblTotalBussines;
        private Label lblTotalRoles;
        private Label lblTotalUsers;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
