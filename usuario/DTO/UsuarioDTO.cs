using System;
using System.ComponentModel.DataAnnotations;

namespace usuario.DTO
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public string CodigoCliente { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        [Required]
        public int TipoContacto { get; set; }
    }
}
