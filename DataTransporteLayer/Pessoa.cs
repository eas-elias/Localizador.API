namespace DataTransportLayer
{

    using System.Collections.Generic;

    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public Endereco EnderecoAtual { get; set; }
        public List<Pessoa> Amigos { get; set; }
    }
}
