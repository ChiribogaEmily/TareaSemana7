namespace Usuarios.Views.Usuarios
{
    partial class UC_Users
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
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 526);
            panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.DarkSlateGray;
            btnClear.ImageAlign = ContentAlignment.BottomRight;
            btnClear.Location = new Point(20, 403);
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
            cbAvailable.Location = new Point(275, 170);
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
            cmbRoles.Location = new Point(275, 95);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(161, 29);
            cmbRoles.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(275, 71);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 13;
            label5.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(54, 223);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 12;
            label4.Text = "Repita su contraseña";
            // 
            // txtRepeatPwd
            // 
            txtRepeatPwd.Location = new Point(54, 247);
            txtRepeatPwd.Name = "txtRepeatPwd";
            txtRepeatPwd.Size = new Size(197, 29);
            txtRepeatPwd.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(54, 146);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 10;
            label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 29);
            txtPassword.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(54, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 29);
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
            btnSave.Location = new Point(0, 472);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(465, 54);
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
            btnEdit.Location = new Point(332, 403);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.ImageAlign = ContentAlignment.BottomRight;
            btnDelete.Location = new Point(173, 403);
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
            label1.Location = new Point(118, 12);
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
            lstUsers.Location = new Point(465, 0);
            lstUsers.Margin = new Padding(4);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(232, 526);
            lstUsers.TabIndex = 0;
            lstUsers.DoubleClick += lstUsers_DoubleClick;
            // 
            // UC_Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            MaximumSize = new Size(697, 526);
            MinimumSize = new Size(697, 526);
            Name = "UC_Users";
            Size = new Size(697, 526);
            Load += Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClear;
        private CheckBox cbAvailable;
        private ComboBox cmbRoles;
        private Label label5;
        public Label label4;
        public TextBox txtRepeatPwd;
        public Label label3;
        public TextBox txtPassword;
        private Label label2;
        private TextBox txtName;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private ListBox lstUsers;
    }
}
