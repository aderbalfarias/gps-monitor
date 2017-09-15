using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GpsMonitor.Domain.Entities;

namespace GpsMonitor.Mvc.Models
{
    public class UsuarioModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = @"Campo obrigatório")]
        [DisplayName(@"Perfil")]
        public int PerfilId { get; set; }

        [Required(ErrorMessage = @"Campo obrigatório")]
        [MaxLength(100, ErrorMessage = @"Limite máximo de 100 caracteres atingido")]
        [MinLength(2, ErrorMessage = @"Limite mínimo de 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = @"Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = @"Endereço de e-mail inválido")]
        [DisplayName(@"E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = @"Campo obrigatório")]
        public string Login { get; set; }

        public string Senha { get; set; }

        [DisplayName(@"Último Acesso")]
        public DateTime? UltimoAcesso { get; set; }

        [DisplayName(@"Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        public string CodigoRecover { get; set; }

        [Required(ErrorMessage = @"Campo obrigatório")]
        public bool Ativo { get; set; }

        public virtual PerfilModel Perfil { get; set; }

        public UsuarioModel MapperEntityToModel(Usuario entity)
        {
            return new UsuarioModel
            {
                UsuarioId = entity.UsuarioId,
                PerfilId = entity.PerfilId,
                Nome = entity.Nome,
                Email = entity.Email,
                Login = entity.Login,
                Senha = entity.Senha,
                UltimoAcesso = entity.UltimoAcesso,
                DataCadastro = entity.DataCadastro,
                CodigoRecover = entity.CodigoRecover,
                Ativo = entity.Ativo,
                Perfil = new PerfilModel().MapperEntityToModel(entity.Perfil)
            };
        }

        public Usuario MapperModelToEntity(UsuarioModel model)
        {
            return new Usuario
            {
                UsuarioId = model.UsuarioId,
                PerfilId = model.PerfilId,
                Nome = model.Nome,
                Email = model.Email,
                Login = model.Login,
                Senha = model.Senha,
                UltimoAcesso = model.UltimoAcesso,
                DataCadastro = model.DataCadastro,
                CodigoRecover = model.CodigoRecover,
                Ativo = model.Ativo,
                Perfil = new PerfilModel().MapperModelToEntity(model.Perfil)
            };
        }
    }
}