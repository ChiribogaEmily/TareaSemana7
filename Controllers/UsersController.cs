using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Usuarios.Models;
using Usuarios.Config;
using Usuarios.Helpers;
namespace Usuarios.Controllers
{
    class UsersController  
    {
        private UsersModel userModel = new UsersModel();
        private readonly Connection cn = new Connection();
        private readonly EncryptPassword encryptPassword = new EncryptPassword();
        public List<UsersModel> getAll() {
        var users = new List<UsersModel>();
            using (var connection = cn.getConnection()) { 
                connection.Open();
                string queryString = $"SELECT Usuarios.*, Roles.Detalle FROM Usuarios inner JOIN Roles on Usuarios.Roles_id = Roles.Rol_Id WHERE Usuarios.Disponibilidad = 1 ;";
                using (var command = new SqlCommand(queryString, connection)) {

                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            var user = new UsersModel {
                            createdAt = DateTime.Parse(reader["createdAt"].ToString()),      
                            Detalle_Rol = reader["Detalle"].ToString(),
                            Id_User = (int)reader["Id_User"],
                            Disponibilidad = (int)reader["Disponibilidad"],
                            Password = reader["Password"].ToString(),
                            Username = reader["Username"].ToString(),
                            Roles_id = (int)reader["Roles_id"]
                            };

                            users.Add(user);
                        }
                    }
                }
            }
            return users;   
        }
        public UsersModel getOne(int Id_User)
        {
            var user = new UsersModel();
            using (var connection = cn.getConnection())
            {
                connection.Open();
                string queryString = $"SELECT Usuarios.*, Roles.Detalle FROM Usuarios " +
                    $"inner JOIN Roles on Usuarios.Roles_id = Roles.Rol_Id " +
                    $"WHERE Usuarios.Disponibilidad = 1 and Usuarios.Id_User = {Id_User};";
                using (var command = new SqlCommand(queryString, connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read()) return null;
                        

                            user = new UsersModel
                            {
                                createdAt = Convert.ToDateTime(reader["createdAt"].ToString()),
                                Detalle_Rol = reader["Detalle"].ToString(),
                                Id_User = (int)reader["Id_User"],
                                Disponibilidad = (int)reader["Disponibilidad"],
                                Password = reader["Password"].ToString(),
                                Username = reader["Username"].ToString(),
                                Roles_id = (int)reader["Roles_id"]
                            };

                        
                        
                    }
                }
                return user;
            }
        }

        public string insert(UsersModel userToAdd) {
            string queryString = $"INSERT INTO Usuarios(Username, Password, Disponibilidad, Roles_Id) " +
                $"Values(@Username, @Password, @Disponibilidad, @Roles_Id);";
            using (var connection = cn.getConnection()) {
                using (var command = new SqlCommand(queryString, connection))
                {
                    string password = encryptPassword.HashPassword(userToAdd.Password);
                    command.Parameters.Add(new SqlParameter("@Username", userToAdd.Username));
                    command.Parameters.Add(new SqlParameter("@Password", password));
                    command.Parameters.Add(new SqlParameter("@Disponibilidad", userToAdd.Disponibilidad));
                    command.Parameters.Add(new SqlParameter("@Roles_Id", userToAdd.Roles_id));
                    connection.Open();
                    if (command.ExecuteNonQuery() != 0) {
                        return "OK";
                    } else {
                        return "Error";
                    }
                }

            }
            

            
        }
        public string updateOne(UsersModel userToUpdate) {
            string queryString = $"UPDATE Usuarios SET Username=@Username, Password=@Password, Disponibilidad=@Disponibilidad, Roles_Id=@Roles_Id " +
                $"WHERE Id_User = @Id_User;";
            using (var connection = cn.getConnection())
            {
                using (var command = new SqlCommand(queryString, connection))
                {
                    string password = encryptPassword.HashPassword(userToUpdate.Password);
                    command.Parameters.Add(new SqlParameter("@Username", userToUpdate.Username));
                    command.Parameters.Add(new SqlParameter("@Password", password));
                    command.Parameters.Add(new SqlParameter("@Disponibilidad", userToUpdate.Disponibilidad));
                    command.Parameters.Add(new SqlParameter("@Roles_Id", userToUpdate.Roles_id));
                    command.Parameters.Add(new SqlParameter("@Id_User", userToUpdate.Id_User));
                    connection.Open();
                    if (command.ExecuteNonQuery() != 0)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error";
                    }
                }

            }
        }
        public string deleteOne(int userId) {
            string queryString = $"UPDATE Usuarios SET  Disponibilidad = 0  " +
                    $"WHERE Id_User = @User_Id;";
            using (var connection = cn.getConnection())
            {
                using (var command = new SqlCommand(queryString, connection))
                {

                    command.Parameters.Add(new SqlParameter("@User_Id", userId));
                    connection.Open();
                    if (command.ExecuteNonQuery() != 0)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error";
                    }
                }

            }

          
        
        }
    }
}
