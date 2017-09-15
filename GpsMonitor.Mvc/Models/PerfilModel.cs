using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GpsMonitor.Domain.Entities;

namespace GpsMonitor.Mvc.Models
{
    public class PerfilModel
    {
        [Key]
        public int PerfilId { get; set; }

        [DisplayName(@"Perfil")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
        
        public virtual IEnumerable<UsuarioModel> Usuario { get; set; }

        public PerfilModel MapperEntityToModel(Perfil entity)
        {
            return new PerfilModel
            {
                PerfilId = entity.PerfilId,
                Descricao = entity.Descricao,
                Ativo = entity.Ativo
            };
        }

        public Perfil MapperModelToEntity(PerfilModel model)
        {
            return new Perfil
            {
                PerfilId = model.PerfilId,
                Descricao = model.Descricao,
                Ativo = model.Ativo
            };
        }
    }
}