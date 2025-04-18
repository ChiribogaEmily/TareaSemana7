
namespace Usuarios.Models
{
    internal class dto_Usuarios
    {
        public int Id_User { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int Disponibilidad { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public int Roles_id { get; set; }
        public string? Detalle_Rol { get; set; } = null;
    }
}
