using System.ComponentModel.DataAnnotations;

namespace usuario.DTO
{
    public class TipoContactoDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
