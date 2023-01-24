using System.ComponentModel.DataAnnotations;
using System;

namespace usuario.Model
{
    public class Usuario
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
