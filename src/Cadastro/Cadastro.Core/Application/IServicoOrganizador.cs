using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application
{
    public interface IServicoOrganizador
    {
        void CadastrarNovoOrganizador(Organizador organizador);
    }
}
