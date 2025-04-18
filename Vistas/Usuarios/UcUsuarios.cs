using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios.Controllers;
using Usuarios.Models;

namespace Usuarios.Views.Usuarios
{
    public partial class UcUsuarios : UserControl
    {
        private cls_Roles cls_roles = new cls_Roles();
        private cls_Usuario cls_usuarios = new cls_Usuario();
        private dto_Usuarios userModel = new dto_Usuarios();
        public UcUsuarios()
        {
            InitializeComponent();
        }



        private void Users_Load(object sender, EventArgs e)
        {
            var roles = cls_roles.todos();

            cmbRoles.DataSource = roles;

            cmbRoles.ValueMember = "Rol_Id";
            cmbRoles.DisplayMember = "Detalle";

            cargarUsuarios();
            disponibilidad();

            lstUsers.ClearSelected();

        }
        public void editar()
        {
            if (lstUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Elija a un usuario de la lista");
                return;
            }

            userModel = cls_usuarios.uno((int)lstUsers.SelectedValue);
            txtNombre.Text = userModel.Username;
            txtContrasena.Text = userModel.Password;
            txtRepetirContrasena.Text = userModel.Password;

            cbDisponibilidad.Checked = userModel.Disponibilidad == 1 ? true : false;
            cmbRoles.SelectedValue = userModel.Roles_id;
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtRepetirContrasena.Text = "";
        }

        public void disponibilidad()
        {
            if (cbDisponibilidad.Checked)
            {
                cbDisponibilidad.Text = "Usuario Activo";
            }
            else
            {
                cbDisponibilidad.Text = "Usuario Innactivo";
            }
        }

        private void cbDisponibilidad_CheckedChanged(object sender, EventArgs e)
        {
            disponibilidad();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var message = "";
            if (contrasenasIguales())
            {
                if (userModel.Id_User == 0)
                {
                    userModel = new dto_Usuarios
                    {
                        Disponibilidad = cbDisponibilidad.Checked ? 1 : 0,
                        Password = txtContrasena.Text,
                        Roles_id = (int)cmbRoles.SelectedValue,
                        Username = txtNombre.Text
                    };
                    message = cls_usuarios.insertar(userModel);
                    limpiar();

                }
                else
                {
                    userModel.Disponibilidad = cbDisponibilidad.Checked ? 1 : 0;
                    userModel.Password = txtContrasena.Text;
                    userModel.Roles_id = (int)cmbRoles.SelectedValue;
                    userModel.Username = txtNombre.Text;
                    message = cls_usuarios.editar(userModel);
                }

                if (message == "OK")
                {
                    MessageBox.Show("Se ha guardado exitosamente");
                    cargarUsuarios();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

        }
        private bool contrasenasIguales()
        {
            return txtContrasena.Text.Trim() == txtRepetirContrasena.Text.Trim();
        }
        private void cargarUsuarios()
        {

            var users = cls_usuarios.todos();
            lstUsers.DataSource = users;


            lstUsers.ValueMember = "Id_User";
            lstUsers.DisplayMember = "Username";
            lstUsers.ClearSelected();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un usuario para la eliminación");
                return;
            }

            var userId = lstUsers.SelectedValue;

            DialogResult dialogBox = MessageBox.Show("¿Está seguro?, esta operacion no se puede revertir", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogBox == DialogResult.Yes)
            {
                var message = cls_usuarios.eliminar((int)userId);

                if (message.Contains("OK"))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    cargarUsuarios();
                    limpiar();
                }
                else
                {
                    MessageBox.Show($"{message} - No se pudo eliminar el registro");
                }
            }

        }


        private void lstUsers_DoubleClick(object sender, EventArgs e)
        {
            editar();
        }

    }
}
