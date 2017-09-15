using GpsMonitor.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GpsMonitor.Data.EntityConfig
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
