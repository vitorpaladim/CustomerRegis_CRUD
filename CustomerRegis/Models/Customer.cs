using System.ComponentModel.DataAnnotations;

namespace CustomerRegis.Models
{
    public class Customer
    {
        [Key] public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "O E-mail não é válido.")]
        public string? Email { get; set; }

        [Display(Name = "Telefone")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Telefone2")]
        public string? Telefone2 { get; set; }

        [Display(Name = "Endereço")]
        public string? Address { get; set; }



    }
}
