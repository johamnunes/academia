using System;

namespace Academia.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}
