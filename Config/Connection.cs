using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Config
{
         class Connection
    {
        private readonly string connectionString = "Server=LAPTOP-L6SUJ856\\ALWAYSDEV;Database=Sistema;uid=root;pwd=123456;TrustServerCertificate=True";


        public SqlConnection getConnection() { 
                return new SqlConnection(connectionString);
        }
    }
}
