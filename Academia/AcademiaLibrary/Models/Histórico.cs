using System;

namespace Academia.Models
{
    public class Histórico
    {
        public int Id { get; set; }
        public string Historico { get; set; }
        public int ContaId { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}
