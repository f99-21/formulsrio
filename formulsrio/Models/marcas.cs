using System.ComponentModel.DataAnnotations;

namespace formulsrio.Models
{
    public class marcas
    {
        [Key]

        [Display(Name = "ID")]
        public int id_marcas { get; set; }
        [Required(ErrorMessage = "El nombre de la marca no es opcional")]
        [Display(Name = "Nombre de la marca")]
        public string? nombre_marca { get; set; }
        [Display(Name = "Estado")]

        public string? estado { get; set; }
    }
}
