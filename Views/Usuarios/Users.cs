using Usuarios.Controllers;
using Usuarios.Models;

namespace Usuarios.Views.Usuarios
{
    public partial class Users : Form
    {
        private RolesController rolesController = new RolesController();
        private UsersController usersController = new UsersController();
        private UsersModel userModel = new UsersModel();
        public Users()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            var roles = rolesController.getAll();

            cmbRoles.DataSource = roles;

            cmbRoles.ValueMember = "Rol_Id";
            cmbRoles.DisplayMember = "Detalle";

            loadUsers();
            availability();

            lstUsers.ClearSelected();

        }
        public void edit()
        {
            if (lstUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Elija a un usuario de la lista");
                return;
            }

            userModel = usersController.getOne((int)lstUsers.SelectedValue);
            txtName.Text = userModel.Username;
            txtPassword.Text = userModel.Password;
            txtRepeatPwd.Text = userModel.Password;

            cbAvailable.Checked = userModel.Disponibilidad == 1 ? true : false;
            cmbRoles.SelectedValue = userModel.Roles_id;
        }

        private void clear()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtRepeatPwd.Text = "";
        }

        public void availability()
        {
            if (cbAvailable.Checked)
            {
                cbAvailable.Text = "Usuario Activo";
            }
            else
            {
                cbAvailable.Text = "Usuario Innactivo";
            }
        }

        private void cbAvailable_CheckedChanged(object sender, EventArgs e)
        {
            availability();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var message = "";
            if (checkIfPasswordsAreEqual())
            {
                MessageBox.Show($"{userModel.Id_User}");
                if (userModel.Id_User == 0)
                {
                    userModel = new UsersModel
                    {
                        Disponibilidad = cbAvailable.Checked ? 1 : 0,
                        Password = txtPassword.Text,
                        Roles_id = (int)cmbRoles.SelectedValue,
                        Username = txtName.Text
                    };
                    message = usersController.insert(userModel);
                    clear();

                }
                else
                {
                    userModel.Disponibilidad = cbAvailable.Checked ? 1 : 0;
                    userModel.Password = txtPassword.Text;
                    userModel.Roles_id = (int)cmbRoles.SelectedValue;
                    userModel.Username = txtName.Text;
                    message = usersController.updateOne(userModel);
                }

                if (message == "OK")
                {
                    MessageBox.Show("Se ha guardado exitosamente");
                    loadUsers();
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
        private bool checkIfPasswordsAreEqual()
        {
            return txtPassword.Text.Trim() == txtRepeatPwd.Text.Trim();
        }
        private void loadUsers()
        {

            var users = usersController.getAll();
            lstUsers.DataSource = users;


            lstUsers.ValueMember = "Id_User";
            lstUsers.DisplayMember = "Username";
            lstUsers.ClearSelected();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                var message = usersController.deleteOne((int)userId);

                if (message.Contains("OK"))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    loadUsers();
                    clear();
                }
                else
                {
                    MessageBox.Show($"{message} - No se pudo eliminar el registro");
                }
            }

        }
        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstUsers_SelectedValueChanged(object sender, EventArgs e)
        {


        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstUsers_DoubleClick(object sender, EventArgs e)
        {
            edit();
        }
    }
}
