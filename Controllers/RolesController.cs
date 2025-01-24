using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Config;
using Usuarios.Models;
using System.Data.SqlClient;

using Usuarios.Helpers;
namespace Usuarios.Controllers
{
    internal class RolesController
    {
        private RolesModel rolesModel = new RolesModel();
        private readonly Connection cn = new Connection();
        public List<RolesModel> getAll()
        {
            var rolesList = new List<RolesModel>();

            using (var connection = cn.getConnection())

            {
                string queryStr = "SELECT * FROM roles";
                using (var command = new System.Data.SqlClient.SqlCommand(queryStr, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rol = new RolesModel
                            {
                                Detalle = reader["Detalle"].ToString(),
                                Rol_Id = (int)reader["Rol_Id"]
                            };
                            rolesList.Add(rol);
                        }
                    }
                }
            }


            return rolesList;
        }


        public RolesModel getOne(int Rol_Id)
        {
            RolesModel rol = null;
            using (var connection = cn.getConnection())
            {
                connection.Open();
                string queryString = $"SELECT * FROM Roles " +
                    $"WHERE Rol_Id = {Rol_Id};";
                using (var command = new System.Data.SqlClient.SqlCommand(queryString, connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                         rol = new RolesModel
                        {
                            Detalle = reader["Detalle"].ToString(),
                            Rol_Id = (int)reader["Rol_Id"]
                        };



                    }
                }
                return rol;
            }
        }

        public string insert(RolesModel roleToAdd)
        {
            string queryString = $"INSERT INTO Roles(Detalle) " +
                $"Values(@Detalle);";
            using (var connection = cn.getConnection())
            {
                using (var command = new System.Data.SqlClient.SqlCommand(queryString, connection))
                {
                    connection.Open();
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Detalle", roleToAdd.Detalle));

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
        public string updateOne(RolesModel roleToUpdate)
        {
            string queryString = $"UPDATE Roles SET Detalle=@Detalle " +
                $"WHERE Rol_Id = @Rol_Id;";
            using (var connection = cn.getConnection())
            {
                using (var command = new System.Data.SqlClient.SqlCommand(queryString, connection))
                {
                    
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Detalle", roleToUpdate.Detalle));
                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Rol_Id", roleToUpdate.Rol_Id));

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
        public string deleteOne(int roleId)
        {
            string queryString = $"DELETE FROM Roles " +
                    $"WHERE Rol_Id = @Rol_Id;";
            using (var connection = cn.getConnection())
            {
                using (var command = new System.Data.SqlClient.SqlCommand(queryString, connection))
                {

                    command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Rol_Id", roleId));
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
