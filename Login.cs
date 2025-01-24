using Usuarios.Controllers;
using Usuarios.Views;

namespace Usuarios
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        AccountModel account = new AccountModel();
        public void btnAceptar_Click_1(object sender, EventArgs e)
        {
            var user = account.login(txtUser.Text, txtPassword.Text);

            if (user.Detalle_Rol == null) {
                MessageBox.Show("El usuario o la contraseña son incorrectas");
            } else {
                var main = new Main();
                main.ShowDialog();
            }
        }

    }
}
