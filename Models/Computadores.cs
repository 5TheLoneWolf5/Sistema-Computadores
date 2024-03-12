using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }
        [Required]
        public string Processador { get; set; }
        [Required]
        public string PlacaMae { get; set; }
        [Required]
        public string Memoria { get; set; }
        [Required]
        public string HD { get; set; }
        [Required]
        public string NumeroPatrimonio { get; set; }
        [Required]
        public DateTime DataCompra { get; set; }
    }
}
