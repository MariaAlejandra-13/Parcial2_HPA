using System;

namespace Entidades
{
    // Representa un registro de la tabla usuarios.
    public class E_Usuario
    {
        public int id { get; set; }
        public string dsId { get; set; }
        public string dsUsuario { get; set; }
        public string dsCorreo { get; set; } = string.Empty;
        public byte[] dsPassword { get; set; }
        public string dsEstado { get; set; }
        public string dsUsuarioCreacion { get; set; }
        public DateTime dtFechaCreacion { get; set; }
        public string dsUsuarioModificacion { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}