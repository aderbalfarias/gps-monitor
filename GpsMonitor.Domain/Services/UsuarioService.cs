using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using GpsMonitor.Domain.Entities;
using GpsMonitor.Domain.Interfaces.Repositories;
using GpsMonitor.Domain.Interfaces.Services;

namespace GpsMonitor.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        #region Fields

        private readonly IUsuarioRepository _usuarioRepository;

        #endregion

        #region Constructors

        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        #endregion

        #region Methods

        public IEnumerable<Usuario> GetUsuariosPaging(ref Pagination paginar)
        {
            int count;

            var result = _usuarioRepository.GetUsuariosPaging(paginar, out count);

            paginar = paginar.CalcularPagination(paginar, count);

            return result;
        }

        public Usuario Login(string user, string password)
        {
            return _usuarioRepository.Login(user, CriptografarSenha(password), password);
        }

        public Usuario RecuperarSenha(string email)
        {
            return _usuarioRepository.RecuperarSenha(email, GetCodigoRecover(), CriptografarSenha(GetCodigoRecover()));
        }

        public void ResetSenha(string login, string codRecover, string newPassword)
        {
            _usuarioRepository.ResetSenha(login, codRecover, CriptografarSenha(newPassword));
        }

        public void EditSenha(int userId, string password, string newPassword)
        {
            _usuarioRepository.EditSenha(userId, CriptografarSenha(password), CriptografarSenha(newPassword));
        }

        public string GetSenha(int usuarioId)
        {
            return _usuarioRepository.GetSenha(usuarioId);
        }

        public string GetCodigoRecover()
        {
            var randNum = new Random();

            int i;
            var codigoRecover = "IT";
            for (i = 0; i < 8; i++)
                codigoRecover += randNum.Next(9);

            return codigoRecover;
        }

        #endregion

        #region Private Methods

        private string CriptografarSenha(string senha)
        {
            return Convert.ToBase64String(new MD5CryptoServiceProvider().ComputeHash(new UTF32Encoding().GetBytes(senha)));
        }

        #endregion
    }
}