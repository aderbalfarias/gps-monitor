using System;
using System.Collections.Generic;
using System.Linq;
using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Repositories;

namespace Imaftec.Gps.Monitor.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        #region Fields

        #endregion

        #region Methods

        public IEnumerable<Usuario> GetUsuariosPaging(Pagination paginar, out int count)
        {
            var result = _context.Usuario;

            count = result.Count();

            return result
                .OrderBy(o => o.Nome)
                .Skip(paginar.SkipPagina(paginar))
                .Take(paginar.QtdeItensPagina)
                .ToList();
        } 

        public Usuario Login(string user, string password, string codRecover)
        {
            var usuario = _context.Usuario
                .FirstOrDefault(u => u.Ativo && u.Login == user && u.Senha == password);

            if (usuario == null)
                return
                    _context.Usuario
                        .FirstOrDefault(u => u.Ativo && u.Login == user && u.Senha == codRecover && u.CodigoRecover == codRecover);

            usuario.UltimoAcesso = DateTime.Now;
            _context.SaveChanges();

            return usuario;
        }

        public Usuario RecuperarSenha(string email, string codigoRecover, string passRecover)
        {
            var usuario = _context.Usuario
                .FirstOrDefault(u => u.Email == email);

            if (usuario == null)
                return null;

            usuario.CodigoRecover = codigoRecover;
            usuario.Senha = passRecover;

            _context.SaveChanges();

            return usuario;
        }

        public void ResetSenha(string login, string codRecover, string newPassword)
        {
            var usuario = _context.Usuario
                .Single(u => u.Login == login && u.CodigoRecover == codRecover);

            usuario.CodigoRecover = null;
            usuario.Senha = newPassword;
            _context.SaveChanges();
        }

        public void EditSenha(int userId, string password, string newPassword)
        {
            var user = _context.Usuario
                .Single(u => u.UsuarioId == userId && u.Senha == password);

            user.Senha = newPassword;
            _context.SaveChanges();
        }

        public string GetSenha(int usuarioId)
        {
            return _context.Usuario
                .First(u => u.UsuarioId == usuarioId).Senha;
        }

        #endregion
    }
}
