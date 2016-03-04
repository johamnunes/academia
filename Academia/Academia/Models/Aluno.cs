using System;

namespace Academia.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complmento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string TelEmergencia { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Obs { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
