using Nucleo.Core;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public OrganizadorId Id { get; private set; }
        public string Nome { get; set; }
        public NomeCompleto Responsavel { get; set; }

        public Organizador(OrganizadorId id)
        {
            Id = id;
        }
    }
}
