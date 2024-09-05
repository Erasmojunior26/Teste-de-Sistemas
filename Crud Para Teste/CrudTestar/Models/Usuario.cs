using System.ComponentModel.DataAnnotations;

namespace CrudTestar.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        public string nomeCompletoUsuario { get; set; }

        [Required]
        [Display(Name = "Nome Usuário")]
        public string usuarioUsuario { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O email inserido não é válido.")]
        public string emailUsuario { get; set; }

        [Required]
        [Display(Name = "Senha")]
        public string senhaUsuario { get; set; }


        [Required]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime nascimentoUsuario { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string telefoneUsuario { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string cpfUsuario { get; set; }
    }
}
