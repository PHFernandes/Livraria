using Livraria.Business;
using Livraria.Entities;
using System.Collections.Generic;

namespace Livraria.Facade
{
    public class LivroFacade
    {
        #region Atributos

        private LivroBusiness _bus;

        #endregion Atributos

        #region Construtor

        public LivroFacade()
        {
            _bus = new LivroBusiness();
        }

        #endregion Construtor

        #region Métodos

        public IList<Livro> Listar()
        {
            return _bus.Listar();
        }

        public void Salvar(Livro e)
        {
            _bus.Salvar(e);
        }

        public void Excluir(int id)
        {
            _bus.Excluir(id);
        }

        public Livro Obter(int id)
        {
            return _bus.Obter(id);
        }

        #endregion Métodos
    }
}