using System;

namespace Academia.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}
