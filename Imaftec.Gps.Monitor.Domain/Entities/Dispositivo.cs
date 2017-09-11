using System.Collections.Generic;

namespace Imaftec.Gps.Monitor.Domain.Entities
{
    public class Dispositivo
    {
        public string DispositivoId { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
