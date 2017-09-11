using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace Imaftec.Gps.Monitor.Domain.Entities
{
    public class Localizacao
    {
        public int LocalizacaoId { get; set; }
        public string DispositivoId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime Data { get; set; }
    }
}
