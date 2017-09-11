using System.Data.Entity.ModelConfiguration;
using Imaftec.Gps.Monitor.Domain.Entities;

namespace Imaftec.Gps.Monitor.Data.EntityConfig
{
    public class PerfilConfiguration : EntityTypeConfiguration<Perfil>
    {
        public PerfilConfiguration()
        {
            HasKey(k => k.PerfilId);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
