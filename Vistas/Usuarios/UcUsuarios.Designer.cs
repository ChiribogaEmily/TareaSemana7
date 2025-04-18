namespace Usuarios.Views.Usuarios
{
    partial class UcUsuarios
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
            btnLimpiar = new Button();
            cbDisponibilidad = new CheckBox();
            cmbRoles = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtRepetirContrasena = new TextBox();
            label3 = new Label();
            txtContrasena = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            lstUsers = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(cbDisponibilidad);
            panel1.Controls.Add(cmbRoles);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRepetirContrasena);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 488);
            panel1.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.BottomRight;
            btnLimpiar.Location = new Point(476, 227);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(80, 35);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cbDisponibilidad
            // 
            cbDisponibilidad.AutoSize = true;
            cbDisponibilidad.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            cbDisponibilidad.Location = new Point(54, 235);
            cbDisponibilidad.Name = "cbDisponibilidad";
            cbDisponibilidad.Size = new Size(118, 21);
            cbDisponibilidad.TabIndex = 15;
            cbDisponibilidad.Text = "Disponibilidad";
            cbDisponibilidad.UseVisualStyleBackColor = true;
            cbDisponibilidad.CheckedChanged += cbDisponibilidad_CheckedChanged;
            // 
            // cmbRoles
            // 
            cmbRoles.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(54, 186);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(233, 25);
            cmbRoles.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(54, 149);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 13;
            label5.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(323, 158);
            label4.Name = "label4";
            label4.Size = new Size(136, 17);
            label4.TabIndex = 12;
            label4.Text = "Repita su contraseña";
            // 
            // txtRepetirContrasena
            // 
            txtRepetirContrasena.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            txtRepetirContrasena.Location = new Point(323, 186);
            txtRepetirContrasena.Name = "txtRepetirContrasena";
            txtRepetirContrasena.Size = new Size(233, 25);
            txtRepetirContrasena.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(323, 71);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 10;
            label3.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            txtContrasena.Location = new Point(323, 95);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(233, 25);
            txtContrasena.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            txtNombre.Location = new Point(54, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 25);
            txtNombre.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.ImageAlign = ContentAlignment.BottomRight;
            btnGuardar.Location = new Point(0, 365);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(663, 39);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Bottom;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Black;
            btnEditar.ImageAlign = ContentAlignment.BottomRight;
            btnEditar.Location = new Point(0, 404);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(663, 42);
            btnEditar.TabIndex = 5;
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
            btnEliminar.Location = new Point(0, 446);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(663, 42);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 1;
            label1.Text = "Formulario de usuarios";
            // 
            // lstUsers
            // 
            lstUsers.Dock = DockStyle.Right;
            lstUsers.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 17;
            lstUsers.Location = new Point(663, 0);
            lstUsers.Margin = new Padding(4);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(232, 488);
            lstUsers.TabIndex = 0;
            lstUsers.DoubleClick += lstUsers_DoubleClick;
            // 
            // UcUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            MaximumSize = new Size(895, 488);
            MinimumSize = new Size(895, 488);
            Name = "UcUsuarios";
            Size = new Size(895, 488);
            Load += Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLimpiar;
        private CheckBox cbDisponibilidad;
        private ComboBox cmbRoles;
        private Label label5;
        public Label label4;
        public TextBox txtRepetirContrasena;
        public Label label3;
        public TextBox txtContrasena;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private ListBox lstUsers;
    }
}
