using Livraria.Entities;
using Livraria.Repository;
using System.Collections.Generic;

namespace Livraria.Business
{
    public class LivroBusiness
    {
        #region Atributos

        private LivroRepository _rep;

        #endregion Atributos

        #region Construtor

        public LivroBusiness()
        {
            _rep = new LivroRepository();
        }

        #endregion Construtor

        #region Métodos

        public IList<Livro> Listar()
        {
            return _rep.Listar();
        }

        public void Salvar(Livro e)
        {
            _rep.Salvar(e);
        }

        public void Excluir(int id)
        {
            _rep.Excluir(id);
        }

        public Livro Obter(int id)
        {
            return _rep.Obter(id);
        }

        #endregion Métodos
    }
}