namespace Usuarios.Views.Roles
{
    partial class UcRoles
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
            btnEditar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtDetalle = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            lstRoles = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDetalle);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstRoles);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 488);
            panel1.TabIndex = 2;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Bottom;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Black;
            btnEditar.ImageAlign = ContentAlignment.BottomRight;
            btnEditar.Location = new Point(0, 320);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(675, 50);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Bottom;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.ImageAlign = ContentAlignment.BottomRight;
            btnEliminar.Location = new Point(0, 370);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(675, 55);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(168, 141);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 8;
            label2.Text = "Detalle";
            // 
            // txtDetalle
            // 
            txtDetalle.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            txtDetalle.Location = new Point(168, 182);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(313, 25);
            txtDetalle.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.ImageAlign = ContentAlignment.BottomRight;
            btnGuardar.Location = new Point(0, 425);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(675, 63);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(168, 17);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 1;
            label1.Text = "Formulario de roles";
            // 
            // lstRoles
            // 
            lstRoles.BorderStyle = BorderStyle.None;
            lstRoles.Dock = DockStyle.Right;
            lstRoles.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lstRoles.FormattingEnabled = true;
            lstRoles.ItemHeight = 17;
            lstRoles.Location = new Point(675, 0);
            lstRoles.Margin = new Padding(4);
            lstRoles.Name = "lstRoles";
            lstRoles.Size = new Size(220, 488);
            lstRoles.TabIndex = 0;
            lstRoles.DoubleClick += lstRoles_DoubleClick;
            // 
            // UcRoles
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximumSize = new Size(895, 488);
            MinimumSize = new Size(895, 488);
            Name = "UcRoles";
            Size = new Size(895, 488);
            Load += FrmRoles_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtDetalle;
        private Button btnGuardar;
        private Label label1;
        private ListBox lstRoles;
    }
}
