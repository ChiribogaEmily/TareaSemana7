using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios.Views.Departamentos;
using Usuarios.Views.Empresas;
using Usuarios.Views.Inicio;
using Usuarios.Views.Roles;
using Usuarios.Views.Usuarios;
namespace Usuarios.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //var users = new Users();
            //users.ShowDialog();
            UC_Users users = new UC_Users();
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(users);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            //var roles = new RolesForm();
            //roles.ShowDialog();
            UC_Roles roles = new UC_Roles();
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(roles);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(home);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            UC_Business business = new UC_Business();
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(business);
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            UC_Departments departments = new UC_Departments();
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(departments);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(home);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
