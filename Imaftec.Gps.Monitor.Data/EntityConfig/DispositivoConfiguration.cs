using System.Data.Entity.ModelConfiguration;
using Imaftec.Gps.Monitor.Domain.Entities;

namespace Imaftec.Gps.Monitor.Data.EntityConfig
{
    class DispositivoConfiguration : EntityTypeConfiguration<Dispositivo>
    {
        public DispositivoConfiguration()
        {
            HasKey(k => k.DispositivoId);
            
            HasRequired(r => r.Usuario)
                .WithMany(w => w.Dispositivo)
                .HasForeignKey(f => f.UsuarioId)
                .WillCascadeOnDelete(false);
        }
    }
}
