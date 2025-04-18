

using System.Data.SqlClient;


namespace Usuarios.Config
{
    class Conexion
    {
        private readonly string cadena = "Server=.;Database=Sistema;uid=root;pwd=123456;TrustServerCertificate=True";


        public SqlConnection obetenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
