using System.Data.SqlClient;
using Usuarios.Models;
using Usuarios.Config;
using Usuarios.Helpers;
namespace Usuarios.Controllers
{
    class cls_Usuario
    {
        private readonly Conexion cn = new Conexion();
        private readonly Encriptar encriptar = new Encriptar();

        public List<dto_Usuarios> todos()
        {
            var users = new List<dto_Usuarios>();
            using (var conexion = cn.obetenerConexion())
            {
                conexion.Open();
                string cadena = $"SELECT Usuarios.*, Roles.Detalle FROM Usuarios inner JOIN Roles on Usuarios.Roles_id = Roles.Rol_Id WHERE Usuarios.Disponibilidad = 1 ;";
                using (var comando = new SqlCommand(cadena, conexion))
                {

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var user = new dto_Usuarios
                            {
                                createdAt = DateTime.Parse(lector["createdAt"].ToString()),
                                Detalle_Rol = lector["Detalle"].ToString(),
                                Id_User = (int)lector["Id_User"],
                                Disponibilidad = (int)lector["Disponibilidad"],
                                Password = lector["Password"].ToString(),
                                Username = lector["Username"].ToString(),
                                Roles_id = (int)lector["Roles_id"]
                            };

                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
        public dto_Usuarios uno(int Id_User)
        {
            var usuario = new dto_Usuarios();
            using (var conexion = cn.obetenerConexion())
            {
                conexion.Open();
                string cadena = $"SELECT Usuarios.*, Roles.Detalle FROM Usuarios " +
                    $"inner JOIN Roles on Usuarios.Roles_id = Roles.Rol_Id " +
                    $"WHERE Usuarios.Disponibilidad = 1 and Usuarios.Id_User = {Id_User};";
                using (var comando = new SqlCommand(cadena, conexion))
                {

                    using (var lector = comando.ExecuteReader())
                    {
                        if (!lector.Read()) return null;


                        usuario = new dto_Usuarios
                        {
                            createdAt = Convert.ToDateTime(lector["createdAt"].ToString()),
                            Detalle_Rol = lector["Detalle"].ToString(),
                            Id_User = (int)lector["Id_User"],
                            Disponibilidad = (int)lector["Disponibilidad"],
                            Password = lector["Password"].ToString(),
                            Username = lector["Username"].ToString(),
                            Roles_id = (int)lector["Roles_id"]
                        };



                    }
                }
                return usuario;
            }
        }

        public string insertar(dto_Usuarios usuarioAgregar)
        {
            string cadena = $"INSERT INTO Usuarios(Username, Password, Disponibilidad, Roles_Id) " +
                $"Values(@Username, @Password, @Disponibilidad, @Roles_Id);";
            using (var conexion = cn.obetenerConexion())
            {
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    string contrasena = encriptar.encriptarContraseña(usuarioAgregar.Password);
                    comando.Parameters.Add(new SqlParameter("@Username", usuarioAgregar.Username));
                    comando.Parameters.Add(new SqlParameter("@Password", contrasena));
                    comando.Parameters.Add(new SqlParameter("@Disponibilidad", usuarioAgregar.Disponibilidad));
                    comando.Parameters.Add(new SqlParameter("@Roles_Id", usuarioAgregar.Roles_id));
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
        public string editar(dto_Usuarios usuarioEditar)
        {
            string cadena = $"UPDATE Usuarios SET Username=@Username, Password=@Password, Disponibilidad=@Disponibilidad, Roles_Id=@Roles_Id " +
                $"WHERE Id_User = @Id_User;";
            using (var conexion = cn.obetenerConexion())
            {
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    string password = encriptar.encriptarContraseña(usuarioEditar.Password);
                    comando.Parameters.Add(new SqlParameter("@Username", usuarioEditar.Username));
                    comando.Parameters.Add(new SqlParameter("@Password", password));
                    comando.Parameters.Add(new SqlParameter("@Disponibilidad", usuarioEditar.Disponibilidad));
                    comando.Parameters.Add(new SqlParameter("@Roles_Id", usuarioEditar.Roles_id));
                    comando.Parameters.Add(new SqlParameter("@Id_User", usuarioEditar.Id_User));
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
        public string eliminar(int usuarioId)
        {
            string cadena = $"UPDATE Usuarios SET  Disponibilidad = 0  " +
                    $"WHERE Id_User = @User_Id;";
            using (var conexion = cn.obetenerConexion())
            {
                using (var comando = new SqlCommand(cadena, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@User_Id", usuarioId));
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
