using System;

namespace Academia.Models
{
    public class Usuário
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}
