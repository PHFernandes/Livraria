using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Entities
{
    [Table("Livro")]
    public class Livro : IEntity
    {
        [Column("IdLivro")]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}