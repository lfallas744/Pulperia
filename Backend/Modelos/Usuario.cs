namespace Backend.Modelos
{
    public enum Role
    {
        Cliente,
        Proveedor,
        Administrador,
        Desarrollo
    }
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string  Contrasena{ get; set; }
        public string Email { get; set; }
        public Role Rol { get; set; }
    }
}
