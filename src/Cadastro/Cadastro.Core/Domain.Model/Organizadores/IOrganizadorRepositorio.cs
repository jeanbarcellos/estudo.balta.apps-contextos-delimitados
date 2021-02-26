using System.Collections.Generic;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public interface IOrganizadorRepositorio
    {
        void Adicionar(Organizador organizador);
        IEnumerable<Organizador> OrganizadoresAtivo();
        IEnumerable<Organizador> OrganizadoresAtivoAnoCorrente();
    }
}
