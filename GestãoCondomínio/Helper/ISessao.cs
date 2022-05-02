using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Helper
{
    public interface ISessao
    {
        public interface ISessao
        {
            void CriarSessaoDoUsuario(UsuarioModel usuario);
            void RemoverSessaoUsuario();
            UsuarioModel BuscarSessaoDoUsuario();
        }

        void CriarSessaoDoUsuario(UsuarioModel usuario);
        object BuscarSessaoDoUsuario();
        void RemoverSessaoUsuario();
    }
}
