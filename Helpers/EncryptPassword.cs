using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
namespace Usuarios.Helpers
{
     class EncryptPassword
    {
        public  string HashPassword(string password) {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string userPassword, string hashedPassword) { 
            return BCrypt.Net.BCrypt.Verify(userPassword, hashedPassword);
        }
    }
}
