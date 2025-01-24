namespace Usuarios.Views.Usuarios
{
    partial class Users
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
            panel1 = new Panel();
            btnClear = new Button();
            cbAvailable = new CheckBox();
            cmbRoles = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtRepeatPwd = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnLeave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            label1 = new Label();
            lstUsers = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(cbAvailable);
            panel1.Controls.Add(cmbRoles);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRepeatPwd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnLeave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 480);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.DarkSlateGray;
            btnClear.ImageAlign = ContentAlignment.BottomRight;
            btnClear.Location = new Point(377, 243);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 54);
            btnClear.TabIndex = 16;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbAvailable
            // 
            cbAvailable.AutoSize = true;
            cbAvailable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbAvailable.Location = new Point(341, 192);
            cbAvailable.Name = "cbAvailable";
            cbAvailable.Size = new Size(134, 25);
            cbAvailable.TabIndex = 15;
            cbAvailable.Text = "Disponibilidad";
            cbAvailable.UseVisualStyleBackColor = true;
            cbAvailable.CheckedChanged += cbAvailable_CheckedChanged;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(341, 119);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(183, 29);
            cmbRoles.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(341, 95);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 13;
            label5.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(54, 235);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 12;
            label4.Text = "Repita su contraseña";
            // 
            // txtRepeatPwd
            // 
            txtRepeatPwd.Location = new Point(54, 268);
            txtRepeatPwd.Name = "txtRepeatPwd";
            txtRepeatPwd.Size = new Size(227, 29);
            txtRepeatPwd.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 168);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 10;
            label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 29);
            txtPassword.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(54, 95);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(54, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 29);
            txtName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Blue;
            btnSave.ImageAlign = ContentAlignment.BottomRight;
            btnSave.Location = new Point(0, 426);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(574, 54);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Olive;
            btnEdit.ImageAlign = ContentAlignment.BottomRight;
            btnEdit.Location = new Point(299, 366);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLeave
            // 
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeave.ForeColor = Color.FromArgb(64, 64, 64);
            btnLeave.ImageAlign = ContentAlignment.BottomRight;
            btnLeave.Location = new Point(155, 366);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(126, 54);
            btnLeave.TabIndex = 4;
            btnLeave.Text = "Salir";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += button3_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ImageAlign = ContentAlignment.BottomRight;
            btnCancel.Location = new Point(12, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 54);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.ImageAlign = ContentAlignment.BottomRight;
            btnDelete.Location = new Point(441, 366);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 54);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 32);
            label1.TabIndex = 1;
            label1.Text = "Formulario de usuarios";
            // 
            // lstUsers
            // 
            lstUsers.Dock = DockStyle.Right;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 21;
            lstUsers.Location = new Point(574, 0);
            lstUsers.Margin = new Padding(4);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(232, 480);
            lstUsers.TabIndex = 0;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            lstUsers.SelectedValueChanged += lstUsers_SelectedValueChanged;
            lstUsers.DoubleClick += lstUsers_DoubleClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 480);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox lstUsers;
        private Button btnSave;
        private Button btnEdit;
        private Button btnLeave;
        private Button btnCancel;
        private Button btnDelete;
        public Label label4;
        public TextBox txtRepeatPwd;
        public Label label3;
        public TextBox txtPassword;
        private Label label2;
        private TextBox txtName;
        private ComboBox cmbRoles;
        private Label label5;
        private CheckBox cbAvailable;
        private Button btnClear;
    }
}