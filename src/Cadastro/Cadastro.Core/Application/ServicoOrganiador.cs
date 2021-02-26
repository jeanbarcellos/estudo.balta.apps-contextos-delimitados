using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application
{
    public class ServicoOrganiador : IServicoOrganizador
    {
        private readonly IOrganizadorRepositorio _repositorio;

        public ServicoOrganiador(IOrganizadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CadastrarNovoOrganizador(Organizador organizador)
        {
            if (organizador.IsValid())
            {
                _repositorio.Adicionar(organizador);
            }
        }
    }
}
