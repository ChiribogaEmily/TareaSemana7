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

namespace Usuarios.Views.Roles
{
    public partial class UcRoles : UserControl
    {
        private dto_Roles rol = new dto_Roles();
        private cls_Roles cls_roles = new cls_Roles();
        public UcRoles()
        {
            InitializeComponent();
        }

        public void editar()
        {
            if (lstRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Elija a un rol de la lista");
                return;
            }

            rol = cls_roles.uno((int)lstRoles.SelectedValue);
            txtDetalle.Text = rol.Detalle;
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un usuario para la eliminación");
                return;
            }

            var rolId = lstRoles.SelectedValue;

            DialogResult dialogBox = MessageBox.Show("¿Está seguro?, esta operacion no se puede revertir", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogBox == DialogResult.Yes)
            {
                var message = cls_roles.elimar((int)rolId);

                if (message.Contains("OK"))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    cargarRoles();
                    clear();
                }
                else
                {
                    MessageBox.Show($"{message} - No se pudo eliminar el registro");
                }
            }
        }


        private void clear()
        {
            txtDetalle.Text = "";

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string message = "";

            if (rol.Rol_Id == 0)
            {
                rol = new dto_Roles
                {
                    Detalle = txtDetalle.Text,
                };
                message = cls_roles.insertar(rol);
                clear();

            }
            else
            {

                rol.Detalle = txtDetalle.Text;
                message = cls_roles.editar(rol);
            }

            if (message == "OK")
            {
                MessageBox.Show("Se ha guardado exitosamente");
                cargarRoles();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar");
            }
        }

        public void cargarRoles()
        {

            var roles = cls_roles.todos();
            lstRoles.DataSource = roles;


            lstRoles.ValueMember = "Rol_Id";
            lstRoles.DisplayMember = "Detalle";
            lstRoles.ClearSelected();
        }
        private void FrmRoles_Load(object sender, EventArgs e)
        {
            cargarRoles();

        }

        private void lstRoles_DoubleClick(object sender, EventArgs e)
        {
            editar();
        }
    }
}
