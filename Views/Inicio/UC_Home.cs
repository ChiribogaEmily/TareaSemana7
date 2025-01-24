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

namespace Usuarios.Views.Inicio
{
    public partial class UC_Home : UserControl
    {
        UsersController usersController = new UsersController();
        RolesController rolesController = new RolesController();
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            var userCount = usersController.getAll().Count;
            var rolesCount = rolesController.getAll().Count;  

            lblTotalRoles.Text = rolesCount.ToString();
            lblTotalUsers.Text =  userCount.ToString();
        }
    }
}
