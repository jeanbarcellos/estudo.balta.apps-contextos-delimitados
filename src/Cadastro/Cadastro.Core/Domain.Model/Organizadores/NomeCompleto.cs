namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class NomeCompleto
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }

        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string EscreverNome()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
