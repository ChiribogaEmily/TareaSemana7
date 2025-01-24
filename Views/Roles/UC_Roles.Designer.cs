namespace Usuarios.Views.Roles
{
    partial class UC_Roles
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
            btnEdit = new Button();
            btnDelete = new Button();
            label2 = new Label();
            txtDetail = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            lstRoles = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEdit);
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
            panel1.Size = new Size(697, 526);
            panel1.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Bottom;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Olive;
            btnEdit.ImageAlign = ContentAlignment.BottomRight;
            btnEdit.Location = new Point(0, 383);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(465, 66);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.ImageAlign = ContentAlignment.BottomRight;
            btnDelete.Location = new Point(0, 449);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(465, 77);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 135);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 8;
            label2.Text = "Detalle";
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(77, 176);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(313, 29);
            txtDetail.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Blue;
            btnSave.ImageAlign = ContentAlignment.BottomRight;
            btnSave.Location = new Point(0, 318);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(465, 63);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            // lstRoles
            // 
            lstRoles.BorderStyle = BorderStyle.None;
            lstRoles.Dock = DockStyle.Right;
            lstRoles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRoles.FormattingEnabled = true;
            lstRoles.ItemHeight = 21;
            lstRoles.Location = new Point(465, 0);
            lstRoles.Margin = new Padding(4);
            lstRoles.Name = "lstRoles";
            lstRoles.Size = new Size(232, 526);
            lstRoles.TabIndex = 0;
            lstRoles.SelectedIndexChanged += lstRoles_SelectedIndexChanged;
            lstRoles.DoubleClick += lstRoles_DoubleClick;
            // 
            // UC_Roles
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximumSize = new Size(697, 526);
            MinimumSize = new Size(697, 526);
            Name = "UC_Roles";
            Size = new Size(697, 526);
            Load += Roles_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEdit;
        private Button btnDelete;
        private Label label2;
        private TextBox txtDetail;
        private Button btnSave;
        private Label label1;
        private ListBox lstRoles;
    }
}
