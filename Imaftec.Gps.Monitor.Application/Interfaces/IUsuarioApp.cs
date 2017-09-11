using System.Collections.Generic;
using Imaftec.Gps.Monitor.Domain.Entities;

namespace Imaftec.Gps.Monitor.Application.Interfaces
{
    public interface IUsuarioApp : IAppBase<Usuario>
    {
        IEnumerable<Usuario> GetUsuariosPaging(ref Pagination paginar);
        Usuario Login(string user, string password);
        Usuario RecuperarSenha(string email);
        void ResetSenha(string login, string codRecover, string newPassword);
        void EditSenha(int userId, string password, string newPassword);
        string GetSenha(int usuarioId);
        string GetCodigoRecover();
    }
}
