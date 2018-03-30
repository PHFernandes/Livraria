using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Entities
{
    [Table("Usuario")]
    public class Usuario : IEntity
    {
        [Column("IdUsuario")]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Login { get; set; }

        [Display(Name = "Administrador")]
        public bool IsAdministrador { get; set; }

        [NotMapped]
        public string Administrador
        {
            get
            {
                return IsAdministrador ? "Sim" : "Não";
            }
        }

        [Required]
        [StringLength(100, ErrorMessage = "A senha deve conter no mínimo 4 caracteres.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmação")]
        [Compare("Senha", ErrorMessage = "As senhas informadas são diferentes.")]
        public string SenhaConfirmacao { get; set; }
    }
}