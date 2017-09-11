using System.Collections.Generic;
using Imaftec.Gps.Monitor.Domain.Entities;

namespace Imaftec.Gps.Monitor.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        IEnumerable<Usuario> GetUsuariosPaging(Pagination paginar, out int count);
        Usuario Login(string user, string password, string codRecover);
        Usuario RecuperarSenha(string email, string codigoRecover, string passRecover);
        void ResetSenha(string login, string codRecover, string newPassword);
        void EditSenha(int userId, string password, string newPassword);
        string GetSenha(int usuarioId);
    }
}
