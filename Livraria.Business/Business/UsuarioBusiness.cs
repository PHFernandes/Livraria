using Livraria.Entities;
using Livraria.Repository;
using System.Collections.Generic;

namespace Livraria.Business
{
    public class UsuarioBusiness
    {
        #region Atributos

        private UsuarioRepository _rep;

        #endregion Atributos

        #region Construtor

        public UsuarioBusiness()
        {
            _rep = new UsuarioRepository();
        }

        #endregion Construtor

        #region Métodos

        public IList<Usuario> Listar()
        {
            return _rep.Listar();
        }

        public void Salvar(Usuario e)
        {
            _rep.Salvar(e);
        }

        public void Excluir(int id)
        {
            _rep.Excluir(id);
        }

        public Usuario Obter(int id)
        {
            return _rep.Obter(id);
        }

        public Usuario ObterPorLoginESenha(string login, string senha)
        {
            return _rep.ObterPorLoginESenha(login, senha);
        }

        #endregion Métodos
    }
}