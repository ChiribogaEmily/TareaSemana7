namespace Usuarios.Views.Departamentos
{
    partial class UcServicios
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
            rtbDesc = new RichTextBox();
            Descripción = new Label();
            btnLimpiar = new Button();
            label5 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            lstBusiness = new ListBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(rtbDesc);
            panel1.Controls.Add(Descripción);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstBusiness);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 488);
            panel1.TabIndex = 2;
            // 
            // rtbDesc
            // 
            rtbDesc.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            rtbDesc.Location = new Point(179, 253);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(340, 96);
            rtbDesc.TabIndex = 19;
            rtbDesc.Text = "";
            // 
            // Descripción
            // 
            Descripción.AutoSize = true;
            Descripción.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Descripción.Location = new Point(179, 233);
            Descripción.Name = "Descripción";
            Descripción.Size = new Size(80, 17);
            Descripción.TabIndex = 17;
            Descripción.Text = "Descripcion";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.BottomRight;
            btnLimpiar.Location = new Point(572, 294);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 37);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(179, 158);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 13;
            label5.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(179, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            txtName.Location = new Point(179, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 25);
            txtName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.Blue;
            btnSave.ImageAlign = ContentAlignment.BottomRight;
            btnSave.Location = new Point(0, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(663, 54);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Black;
            btnEditar.ImageAlign = ContentAlignment.BottomRight;
            btnEditar.Location = new Point(572, 337);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 37);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Bottom;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.ImageAlign = ContentAlignment.BottomRight;
            btnEliminar.Location = new Point(0, 434);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(663, 54);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(50, 11);
            label1.Name = "label1";
            label1.Size = new Size(154, 17);
            label1.TabIndex = 1;
            label1.Text = "Formulario de Servicios";
            // 
            // lstBusiness
            // 
            lstBusiness.Dock = DockStyle.Right;
            lstBusiness.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lstBusiness.FormattingEnabled = true;
            lstBusiness.ItemHeight = 17;
            lstBusiness.Items.AddRange(new object[] { "Concierto completo ", "Show acústico ", "Presentación para eventos " });
            lstBusiness.Location = new Point(663, 0);
            lstBusiness.Margin = new Padding(4);
            lstBusiness.Name = "lstBusiness";
            lstBusiness.Size = new Size(232, 488);
            lstBusiness.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(179, 190);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 25);
            numericUpDown1.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(378, 190);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 25);
            numericUpDown2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(378, 158);
            label3.Name = "label3";
            label3.Size = new Size(114, 17);
            label3.TabIndex = 21;
            label3.Text = "Duración (Horas)";
            // 
            // UcServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            MaximumSize = new Size(895, 488);
            MinimumSize = new Size(895, 488);
            Name = "UcServicios";
            Size = new Size(895, 488);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox rtbAddress;
        private Label Descripción;
        private Button btnLimpiar;
        private ComboBox cmbCategory;
        private Label label5;
        private Label label2;
        private TextBox txtName;
        private Button btnSave;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private ListBox lstBusiness;
        private RichTextBox rtbDesc;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}
