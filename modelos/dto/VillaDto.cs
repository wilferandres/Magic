using System.ComponentModel.DataAnnotations;

namespace MagiVilla_api.modelos.dto
{
    public class VillaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string nombre { get; set; }

        [Required]
        [MaxLength(30)]
        public string apellido { get; set; }
    }
}
