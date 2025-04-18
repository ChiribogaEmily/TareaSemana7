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
    internal class cls_Roles
    {
        private dto_Roles rolesModel = new dto_Roles();
        private readonly Conexion cn = new Conexion();
        public List<dto_Roles> todos()
        {
            var listaRoles = new List<dto_Roles>();

            using (var conexion = cn.obetenerConexion())

            {
                string queryStr = "SELECT * FROM roles";
                using (var comando = new System.Data.SqlClient.SqlCommand(queryStr, conexion))
                {
                    conexion.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rol = new dto_Roles
                            {
                                Detalle = reader["Detalle"].ToString(),
                                Rol_Id = (int)reader["Rol_Id"]
                            };
                            listaRoles.Add(rol);
                        }
                    }
                }
            }


            return listaRoles;
        }


        public dto_Roles uno(int Rol_Id)
        {
            dto_Roles rol = null;
            using (var conexion = cn.obetenerConexion())
            {
                conexion.Open();
                string cadena = $"SELECT * FROM Roles " +
                    $"WHERE Rol_Id = {Rol_Id};";
                using (var comando = new System.Data.SqlClient.SqlCommand(cadena, conexion))
                {

                    using (var reader = comando.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        rol = new dto_Roles
                        {
                            Detalle = reader["Detalle"].ToString(),
                            Rol_Id = (int)reader["Rol_Id"]
                        };



                    }
                }
                return rol;
            }
        }

        public string insertar(dto_Roles roleToAdd)
        {
            string cadena = $"INSERT INTO Roles(Detalle) " +
                $"Values(@Detalle);";
            using (var conexion = cn.obetenerConexion())
            {
                using (var comando = new System.Data.SqlClient.SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    comando.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Detalle", roleToAdd.Detalle));

                    if (comando.ExecuteNonQuery() != 0)
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
        public string editar(dto_Roles roleToUpdate)
        {
            string cadena = $"UPDATE Roles SET Detalle=@Detalle " +
                $"WHERE Rol_Id = @Rol_Id;";
            using (var conexion = cn.obetenerConexion())
            {
                using (var comando = new System.Data.SqlClient.SqlCommand(cadena, conexion))
                {

                    comando.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Detalle", roleToUpdate.Detalle));
                    comando.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Rol_Id", roleToUpdate.Rol_Id));

                    conexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
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
        public string elimar(int rolId)
        {
            string cadena = $"DELETE FROM Roles " +
                    $"WHERE Rol_Id = @Rol_Id;";
            using (var conexion = cn.obetenerConexion())
            {
                using (var comando = new System.Data.SqlClient.SqlCommand(cadena, conexion))
                {

                    comando.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Rol_Id", rolId));
                    conexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
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
