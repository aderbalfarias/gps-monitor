using System.Data.Entity.ModelConfiguration;
using GpsMonitor.Domain.Entities;

namespace GpsMonitor.Data.EntityConfig
{
    public class LocalizacaoConfiguration : EntityTypeConfiguration<Localizacao>
    {
        public LocalizacaoConfiguration()
        {
            HasKey(k => k.LocalizacaoId);

            Property(p => p.Latitude)
               .IsRequired()
               .HasMaxLength(20);
            
            Property(p => p.Longitude)
               .IsRequired()
               .HasMaxLength(20);
        }
    }
}
