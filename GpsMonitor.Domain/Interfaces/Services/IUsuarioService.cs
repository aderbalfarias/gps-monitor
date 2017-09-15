using System.Collections.Generic;
using GpsMonitor.Domain.Entities;

namespace GpsMonitor.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
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
