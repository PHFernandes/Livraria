using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Entities
{
    public abstract class BaseEntity
    {
        [NotMapped]
        public string Mensagem { get; set; }
    }
}