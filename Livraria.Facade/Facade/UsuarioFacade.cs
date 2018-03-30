using Livraria.Entities;
using Livraria.Business;
using System.Collections.Generic;

namespace Livraria.Facade
{
    public class UsuarioFacade
    {
        #region Atributos

        private UsuarioBusiness _bus;

        #endregion Atributos

        #region Construtor

        public UsuarioFacade()
        {
            _bus = new UsuarioBusiness();
        }

        #endregion Construtor

        #region Métodos

        public IList<Usuario> Listar()
        {
            return _bus.Listar();
        }

        public void Salvar(Usuario e)
        {
            _bus.Salvar(e);
        }

        public void Excluir(int id)
        {
            _bus.Excluir(id);
        }

        public Usuario Obter(int id)
        {
            return _bus.Obter(id);
        }

        public Usuario ObterPorLoginESenha(string login, string senha)
        {
            return _bus.ObterPorLoginESenha(login, senha);
        }

        #endregion Métodos
    }
}