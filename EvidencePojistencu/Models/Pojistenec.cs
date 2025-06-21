using System.ComponentModel.DataAnnotations;

namespace EvidencePojistencu.Models
{
    public class Pojistenec
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Jmeno { get; set; } = string.Empty;

        [Required]
        public string Prijmeni { get; set; } = string.Empty;

        [Range(0, 120)]
        public int Vek { get; set; }

        [Required]
        [RegularExpression(@"^\d{9,15}$", ErrorMessage = "Zadej platné telefonní číslo bez mezer.")]
        public string Telefon { get; set; } = string.Empty;
    }
}
