using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Core.Application.Organizadores
{
    public interface IServicoOrganizador
    {
        void CadastrarNovoOrganizador(Organizador organizador);
    }
}
