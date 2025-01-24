namespace Usuarios.Views
{
    partial class Main
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
            btnUsers = new Button();
            btnRoles = new Button();
            panel1 = new Panel();
            button4 = new Button();
            btnDepartments = new Button();
            btnBusiness = new Button();
            button1 = new Button();
            containerPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 2;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnUsers.ForeColor = Color.Blue;
            btnUsers.Location = new Point(11, 119);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(167, 62);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderSize = 2;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRoles.ForeColor = Color.Blue;
            btnRoles.Location = new Point(11, 205);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(167, 61);
            btnRoles.TabIndex = 1;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnDepartments);
            panel1.Controls.Add(btnBusiness);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnRoles);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 526);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(64, 64, 64);
            button4.Location = new Point(11, 452);
            button4.Name = "button4";
            button4.Size = new Size(167, 61);
            button4.TabIndex = 5;
            button4.Text = "Cerrar Sesión";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnLogout_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.FlatAppearance.BorderSize = 2;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDepartments.ForeColor = Color.Blue;
            btnDepartments.Location = new Point(11, 363);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(167, 61);
            btnDepartments.TabIndex = 4;
            btnDepartments.Text = "Departamentos";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnBusiness
            // 
            btnBusiness.FlatAppearance.BorderSize = 2;
            btnBusiness.FlatStyle = FlatStyle.Flat;
            btnBusiness.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBusiness.ForeColor = Color.Blue;
            btnBusiness.Location = new Point(11, 284);
            btnBusiness.Name = "btnBusiness";
            btnBusiness.Size = new Size(167, 61);
            btnBusiness.TabIndex = 3;
            btnBusiness.Text = "Empresas";
            btnBusiness.UseVisualStyleBackColor = true;
            btnBusiness.Click += btnBusiness_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(11, 34);
            button1.Name = "button1";
            button1.Size = new Size(167, 62);
            button1.TabIndex = 2;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnHome_Click;
            // 
            // containerPanel
            // 
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(192, 0);
            containerPanel.MaximumSize = new Size(697, 526);
            containerPanel.MinimumSize = new Size(697, 526);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(697, 526);
            containerPanel.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 526);
            Controls.Add(containerPanel);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsers;
        private Button btnRoles;
        private Panel panel1;
        private Panel containerPanel;
        private Button button1;
        private Button button4;
        private Button btnDepartments;
        private Button btnBusiness;
    }
}