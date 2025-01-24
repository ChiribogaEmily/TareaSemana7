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
    public partial class UC_Roles : UserControl
    {
        private RolesModel rolesModel = new RolesModel();
        private RolesController roleController = new RolesController();
        public UC_Roles()
        {
            InitializeComponent();
        }

        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void edit()
        {
            if (lstRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Elija a un rol de la lista");
                return;
            }

            rolesModel = roleController.getOne((int)lstRoles.SelectedValue);
            txtDetail.Text = rolesModel.Detalle;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                var message = roleController.deleteOne((int)rolId);

                if (message.Contains("OK"))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    loadRoles();
                    clear();
                }
                else
                {
                    MessageBox.Show($"{message} - No se pudo eliminar el registro");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
        private void clear()
        {
            txtDetail.Text = "";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "";

            if (rolesModel.Rol_Id == 0)
            {
                rolesModel = new RolesModel
                {
                    Detalle = txtDetail.Text,
                };
                message = roleController.insert(rolesModel);

            }
            else
            {
                rolesModel.Detalle = txtDetail.Text;
                message = roleController.updateOne(rolesModel);
            }

            if (message == "OK")
            {
                MessageBox.Show("Se ha guardado exitosamente");
                loadRoles();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar");
            }
            clear();
            lstRoles.ClearSelected();
        }
        public void loadRoles()
        {

            var roles = roleController.getAll();
            lstRoles.DataSource = roles;


            lstRoles.ValueMember = "Rol_Id";
            lstRoles.DisplayMember = "Detalle";
            lstRoles.ClearSelected();
        }
        private void Roles_Load(object sender, EventArgs e)
        {
            loadRoles();

        }

        private void lstRoles_DoubleClick(object sender, EventArgs e)
        {
            edit();
        }
    }
}
