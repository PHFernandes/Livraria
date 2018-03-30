using Livraria.Entities;
using System.Linq;

namespace Livraria.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public Usuario ObterPorLoginESenha(string login, string senha)
        {
            return Query().Where(x => x.Login == login && x.Senha == senha).FirstOrDefault();
        }
    }
}