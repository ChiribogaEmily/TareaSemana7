using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Config;
using Usuarios.Helpers;
using Usuarios.Models;

namespace Usuarios.Controllers
{
    internal class AccountModel
    {
        private RolesModel rolesModel = new RolesModel();
        private readonly Connection cn = new Connection();
        private EncryptPassword encryptPassword = new EncryptPassword();

        public UsersModel login(string userName, string password) {
            using (var connection = cn.getConnection())

            {
                string queryStr = $"SELECT * FROM Usuarios inner JOIN Roles on Usuarios.Roles_id = Roles.Rol_Id WHERE Usuarios.Username = '{userName}';";
                using (var command = new SqlCommand(queryStr, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) {

                            if (encryptPassword.VerifyPassword(password, reader["Password"].ToString()))
                            {
                                return new UsersModel
                                {
                                    Id_User = (int)reader["Id_User"],
                                    Username = reader["Username"].ToString(),

                                    Roles_id = (int)reader["Roles_id"],
                                    Detalle_Rol = reader["Detalle"].ToString()
                                };
                            }
                            else {
                                return new UsersModel();
                            }
                        }
                        else { return new  UsersModel(); }
                        

                    }
                }
            }


          
        }
    }

        // Token
        // isLoggedIn
        // Logout
    }
