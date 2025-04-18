using Usuarios.Controllers;
using Usuarios.Views;

namespace Usuarios
{
    public partial class InicioSesion : Form
    {

        public InicioSesion()
        {
            InitializeComponent();

        }
        cls_Cuenta cuenta = new cls_Cuenta();
        public void btnAceptar_Click_1(object sender, EventArgs e)
        {
            var user = cuenta.iniciar_sesion(txtUsuario.Text, txtContrase�a.Text);

            if (user.Detalle_Rol == null)
            {
                MessageBox.Show("El usuario o la contrase�a son incorrectas");
            }
            else
            {
                var frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
            }
        }

    }
}
