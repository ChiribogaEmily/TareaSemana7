
namespace Usuarios.Helpers
{
    class Encriptar
    {
        public string encriptarContraseña(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool verificarContrasena(string userPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(userPassword, hashedPassword);
        }
    }
}
