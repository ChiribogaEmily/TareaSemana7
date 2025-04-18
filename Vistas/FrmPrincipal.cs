
using Usuarios.Views.Departamentos;
using Usuarios.Views.Roles;
using Usuarios.Views.Usuarios;
namespace Usuarios.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            UcUsuarios usuarios = new UcUsuarios();
            contenedor.Controls.Clear();
            contenedor.Controls.Add(usuarios);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {

            UcRoles roles = new UcRoles();
            contenedor.Controls.Clear();
            contenedor.Controls.Add(roles);
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }





        private void btnServicios_Click(object sender, EventArgs e)
        {
            UcServicios servicios = new UcServicios();
            contenedor.Controls.Clear();
            contenedor.Controls.Add(servicios);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
