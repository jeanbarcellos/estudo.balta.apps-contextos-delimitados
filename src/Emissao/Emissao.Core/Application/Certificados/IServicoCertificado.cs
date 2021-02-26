using Emissao.Core.Domain.Model.Certificados;

namespace Emissao.Core.Application.Certificados
{
    public interface IServicoCertificado
    {
        Certificado EmitirCertificado(EventoId eventoId, string cpf);
    }
}
