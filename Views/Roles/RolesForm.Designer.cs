namespace Usuarios.Views.Roles
{
    partial class RolesForm
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
            lstRoles = new ListBox();
            label1 = new Label();
            btnSave = new Button();
            txtDetail = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnEdit = new Button();
            btnLeave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstRoles
            // 
            lstRoles.Dock = DockStyle.Right;
            lstRoles.FormattingEnabled = true;
            lstRoles.ItemHeight = 21;
            lstRoles.Location = new Point(428, 0);
            lstRoles.Margin = new Padding(4);
            lstRoles.Name = "lstRoles";
            lstRoles.Size = new Size(232, 370);
            lstRoles.TabIndex = 0;
            lstRoles.DoubleClick += lstRoles_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 1;
            label1.Text = "Formulario de roles";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Blue;
            btnSave.ImageAlign = ContentAlignment.BottomRight;
            btnSave.Location = new Point(155, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 54);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(90, 127);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(227, 29);
            txtDetail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 90);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 8;
            label2.Text = "Detalle";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnLeave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDetail);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstRoles);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 370);
            panel1.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Olive;
            btnEdit.ImageAlign = ContentAlignment.BottomRight;
            btnEdit.Location = new Point(295, 243);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 54);
            btnEdit.TabIndex = 12;
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
            btnLeave.Location = new Point(12, 304);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(126, 54);
            btnLeave.TabIndex = 11;
            btnLeave.Text = "Salir";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ImageAlign = ContentAlignment.BottomRight;
            btnCancel.Location = new Point(12, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 54);
            btnCancel.TabIndex = 10;
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
            btnDelete.Location = new Point(295, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 54);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Roles
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 370);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Roles";
            Text = "Roles";
            Load += Roles_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstRoles;
        private Label label1;
        private Button btnSave;
        private TextBox txtDetail;
        private Label label2;
        private Panel panel1;
        private Button btnEdit;
        private Button btnLeave;
        private Button btnCancel;
        private Button btnDelete;
    }
}