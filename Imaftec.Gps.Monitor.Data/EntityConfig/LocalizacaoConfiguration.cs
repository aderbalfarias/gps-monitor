using System.Data.Entity.ModelConfiguration;
using Imaftec.Gps.Monitor.Domain.Entities;

namespace Imaftec.Gps.Monitor.Data.EntityConfig
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
