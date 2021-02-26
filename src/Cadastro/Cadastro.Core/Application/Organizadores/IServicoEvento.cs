using Cadastro.Core.Domain.Model.Eventos;

namespace Cadastro.Core.Application.Organizadores
{
    public interface IServicoEvento
    {
        Evento RecuperarEvento(EventoId eventoId);
    }
}
