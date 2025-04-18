
using System.Data.SqlClient;

using Usuarios.Config;
using Usuarios.Helpers;
using Usuarios.Models;

namespace Usuarios.Controllers
{
    internal class cls_Cuenta
    {
        private dto_Roles rol = new dto_Roles();
        private readonly Conexion cn = new Conexion();
        private Encriptar encriptar = new Encriptar();

        public dto_Usuarios iniciar_sesion(string userName, string password)
        {
            using (var conexion = cn.obetenerConexion())

            {
                string cadena = $"SELECT * FROM Usuarios inner JOIN Roles on Usuarios.Roles_id = Roles.Rol_Id WHERE Usuarios.Username = '{userName}';";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {

                            if (encriptar.verificarContrasena(password, lector["Password"].ToString()))
                            {
                                return new dto_Usuarios
                                {
                                    Id_User = (int)lector["Id_User"],
                                    Username = lector["Username"].ToString(),

                                    Roles_id = (int)lector["Roles_id"],
                                    Detalle_Rol = lector["Detalle"].ToString()
                                };
                            }
                            else
                            {
                                return new dto_Usuarios();
                            }
                        }
                        else { return new dto_Usuarios(); }


                    }
                }
            }



        }
    }
}
