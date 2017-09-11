using System.Collections.Generic;

namespace Imaftec.Gps.Monitor.Domain.Entities
{
    public class Perfil
    {
        public int PerfilId { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }
        
        //public virtual IEnumerable<Usuario> Usuario { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
