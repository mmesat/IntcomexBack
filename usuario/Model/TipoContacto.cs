using System.ComponentModel.DataAnnotations;

namespace usuario.Model
{
    public class TipoContacto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
